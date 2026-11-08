using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Bài tập 3: quản lý tài khoản, mọi thao tác đều gọi Stored Procedure
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
            LoadAccounts();
        }

        // Nạp danh sách vai trò để chọn khi thêm tài khoản
        private void LoadRoles()
        {
            cbbRole.DisplayMember = "RoleName";
            cbbRole.ValueMember = "ID";
            cbbRole.DataSource = DataProvider.GetData(new SqlCommand("EXECUTE Role_GetAll"));
        }

        private void LoadAccounts()
        {
            DataTable dt = DataProvider.GetData(new SqlCommand("EXECUTE Account_GetAll"));

            lvAccounts.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["AccountName"].ToString());
                item.SubItems.Add(row["FullName"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Tell"].ToString());
                item.SubItems.Add(row["DateCreated"].ToString());
                lvAccounts.Items.Add(item);
            }

            // Danh sách mới chưa có tài khoản nào được chọn
            txtAccountName.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtTell.Text = "";
            btnUpdate.Enabled = false;
            btnResetPassword.Enabled = false;
        }

        private void lvAccounts_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvAccounts.SelectedItems[0];

            txtAccountName.Text = item.Text;
            txtFullName.Text = item.SubItems[1].Text;
            txtEmail.Text = item.SubItems[2].Text;
            txtTell.Text = item.SubItems[3].Text;

            btnUpdate.Enabled = true;
            btnResetPassword.Enabled = true;
        }

        // Thêm vai trò mới trước khi thêm tài khoản
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AddRoleForm roleForm = new AddRoleForm();
            roleForm.FormClosed += new FormClosedEventHandler(roleForm_FormClosed);

            roleForm.Show(this);
        }

        void roleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadRoles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "" || txtPassword.Text == "" || txtFullName.Text == "" || cbbRole.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản, mật khẩu, họ tên và chọn vai trò");
                return;
            }

            SqlCommand cmd = new SqlCommand("EXECUTE Account_Insert @accountName, @password, @fullName, @email, @tell, @roleID");
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value = txtAccountName.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 200).Value = txtPassword.Text;
            cmd.Parameters.Add("@fullName", SqlDbType.NVarChar, 1000).Value = txtFullName.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000).Value = txtEmail.Text;
            cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200).Value = txtTell.Text;
            cmd.Parameters.Add("@roleID", SqlDbType.Int).Value = cbbRole.SelectedValue;

            if (DataProvider.Execute(cmd) > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công", "Message");
                LoadAccounts();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE Account_Update @accountName, @fullName, @email, @tell");
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value = txtAccountName.Text;
            cmd.Parameters.Add("@fullName", SqlDbType.NVarChar, 1000).Value = txtFullName.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000).Value = txtEmail.Text;
            cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200).Value = txtTell.Text;

            if (DataProvider.Execute(cmd) > 0)
            {
                MessageBox.Show("Cập nhật tài khoản thành công", "Message");
                LoadAccounts();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            // ponytail: mật khẩu mặc định cố định, đổi sang mật khẩu ngẫu nhiên khi cần bảo mật hơn
            string newPassword = "123456";

            SqlCommand cmd = new SqlCommand("EXECUTE Account_ResetPassword @accountName, @password");
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value = txtAccountName.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 200).Value = newPassword;

            if (DataProvider.Execute(cmd) > 0)
                MessageBox.Show("Mật khẩu mới của tài khoản " + txtAccountName.Text + " là " + newPassword, "Message");
        }

        // Menu chuột phải
        private void tsmViewRoles_Click(object sender, EventArgs e)
        {
            if (lvAccounts.SelectedItems.Count == 0) return;

            AccountRolesForm rolesForm = new AccountRolesForm();
            // Có thể thêm vai trò mới ở form này nên đóng xong thì nạp lại cbbRole
            rolesForm.FormClosed += new FormClosedEventHandler(roleForm_FormClosed);

            rolesForm.Show(this);
            rolesForm.LoadRoles(lvAccounts.SelectedItems[0].Text);
        }

        private void tsmViewLog_Click(object sender, EventArgs e)
        {
            if (lvAccounts.SelectedItems.Count == 0) return;

            AccountLogForm logForm = new AccountLogForm();
            logForm.Show(this);
            logForm.LoadLog(lvAccounts.SelectedItems[0].Text);
        }
    }
}
