using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Bài tập 2: hóa đơn bán trong một khoảng thời gian, gọi thủ tục Bills_GetByDate
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE Bills_GetByDate @fromDate, @toDate");
            cmd.Parameters.Add("@fromDate", SqlDbType.Date).Value = dtpFrom.Value.Date;
            cmd.Parameters.Add("@toDate", SqlDbType.Date).Value = dtpTo.Value.Date;

            DataTable dt = DataProvider.GetData(cmd);
            dgvOrders.DataSource = dt;

            // Cộng dồn tiền của các hóa đơn vừa lấy
            double amount = 0, discount = 0;
            foreach (DataRow row in dt.Rows)
            {
                amount += Convert.ToDouble(row["Tiền chưa giảm"]);
                discount += Convert.ToDouble(row["Giảm giá"]);
            }

            lblAmount.Text = "Tổng tiền chưa giảm giá: " + amount.ToString("N0");
            lblDiscount.Text = "Tổng tiền giảm giá: " + discount.ToString("N0");
            lblTotal.Text = "Thực thu: " + (amount - discount).ToString("N0");
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nhấp đôi vào dòng tiêu đề thì bỏ qua
            if (e.RowIndex < 0) return;

            int billID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["Mã HĐ"].Value);

            OrderDetailsForm orderDetailsForm = new OrderDetailsForm();
            orderDetailsForm.Show(this);
            orderDetailsForm.LoadOrderDetails(billID);
        }
    }
}
