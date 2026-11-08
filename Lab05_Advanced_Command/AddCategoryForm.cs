using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Bài tập 1: thêm mới nhóm món ăn bằng thủ tục Category_Insert
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cbbType.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập tên nhóm và chọn loại");
                return;
            }

            SqlCommand cmd = new SqlCommand("EXECUTE Category_Insert @name, @type");
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = txtName.Text;
            // Thứ tự trong cbbType: 0 = Thức uống, 1 = Đồ ăn (đúng giá trị cột Type)
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = cbbType.SelectedIndex;

            if (DataProvider.Execute(cmd) > 0)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công", "Message");
                txtName.ResetText();
            }
        }
    }
}
