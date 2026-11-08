using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Bài tập 3: thêm mới vai trò bằng thủ tục Role_Insert
    public partial class AddRoleForm : Form
    {
        public AddRoleForm()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtRoleName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên vai trò");
                return;
            }

            SqlCommand cmd = new SqlCommand("EXECUTE Role_Insert @roleName");
            cmd.Parameters.Add("@roleName", SqlDbType.NVarChar, 1000).Value = txtRoleName.Text;

            if (DataProvider.Execute(cmd) > 0)
            {
                MessageBox.Show("Thêm vai trò thành công", "Message");
                txtRoleName.ResetText();
            }
        }
    }
}
