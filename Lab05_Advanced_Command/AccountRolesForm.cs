using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Bài tập 3: toàn bộ vai trò của hệ thống, vai trò nào được gán cho tài khoản thì cột đầu được check
    public partial class AccountRolesForm : Form
    {
        // Tài khoản đang xem
        string accountName;

        public AccountRolesForm()
        {
            InitializeComponent();
        }

        public void LoadRoles(string accountName)
        {
            this.accountName = accountName;
            this.Text = "Vai trò của tài khoản: " + accountName;

            SqlCommand cmd = new SqlCommand("EXECUTE RoleAccount_GetByAccount @accountName");
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value = accountName;
            dgvRoles.DataSource = DataProvider.GetData(cmd);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddRoleForm roleForm = new AddRoleForm();
            roleForm.FormClosed += new FormClosedEventHandler(roleForm_FormClosed);

            roleForm.Show(this);
        }

        void roleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadRoles(accountName);
        }

        // Lưu lại vai trò được check / bỏ check cho tài khoản
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ghi nhận ô check vừa bấm
            dgvRoles.EndEdit();

            foreach (DataGridViewRow row in dgvRoles.Rows)
            {
                SqlCommand cmd = new SqlCommand("EXECUTE RoleAccount_Update @roleID, @accountName, @actived");
                cmd.Parameters.Add("@roleID", SqlDbType.Int).Value = row.Cells["colRoleID"].Value;
                cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value = accountName;
                cmd.Parameters.Add("@actived", SqlDbType.Bit).Value = row.Cells["colAssigned"].Value;
                DataProvider.Execute(cmd);
            }

            MessageBox.Show("Cập nhật vai trò cho tài khoản " + accountName + " thành công", "Message");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
