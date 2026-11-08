using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Bài tập 3: nhật ký hoạt động = các hóa đơn tài khoản đã lập
    public partial class AccountLogForm : Form
    {
        // Hóa đơn của tài khoản, dòng thứ i ứng với mục thứ i trong ListBox
        DataTable billTable;

        public AccountLogForm()
        {
            InitializeComponent();
        }

        public void LoadLog(string accountName)
        {
            this.Text = "Nhật ký hoạt động của tài khoản: " + accountName;

            SqlCommand cmd = new SqlCommand("EXECUTE Bills_GetByAccount @accountName");
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value = accountName;
            billTable = DataProvider.GetData(cmd);

            lbBills.Items.Clear();
            double total = 0;
            foreach (DataRow row in billTable.Rows)
            {
                lbBills.Items.Add("HĐ " + row["ID"] + " - " + row["CheckoutDate"]);
                total += Convert.ToDouble(row["Amount"]);
            }

            lblSummary.Text = "Số hóa đơn đã lập: " + billTable.Rows.Count + "    Tổng tiền: " + total.ToString("N0");
        }

        private void lbBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBills.SelectedIndex < 0) return;

            DataRow row = billTable.Rows[lbBills.SelectedIndex];

            lblBillInfo.Text = "Mã hóa đơn: " + row["ID"] +
                               "\nTên hóa đơn: " + row["Name"] +
                               "\nBàn: " + row["TableID"] +
                               "\nNgày lập: " + row["CheckoutDate"] +
                               "\nTổng tiền: " + row["Amount"] +
                               "    Tỉ lệ giảm giá: " + row["Discount"] +
                               "    Tỉ lệ thuế: " + row["Tax"] +
                               "\nTrạng thái: " + (Convert.ToBoolean(row["Status"]) ? "Đã thanh toán" : "Chưa thanh toán");

            dgvBillDetails.DataSource = OrderDetailsForm.GetOrderDetails(Convert.ToInt32(row["ID"]));
        }
    }
}
