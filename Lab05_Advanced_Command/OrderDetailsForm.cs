using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Bài tập 2: các món đã mua trong một hóa đơn (bài tập 3 cũng dùng lại)
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public static DataTable GetOrderDetails(int billID)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE BillDetails_GetByBillID @billID");
            cmd.Parameters.Add("@billID", SqlDbType.Int).Value = billID;
            return DataProvider.GetData(cmd);
        }

        public void LoadOrderDetails(int billID)
        {
            this.Text = "Chi tiết hóa đơn số " + billID;
            dgvOrderDetails.DataSource = GetOrderDetails(billID);
        }
    }
}
