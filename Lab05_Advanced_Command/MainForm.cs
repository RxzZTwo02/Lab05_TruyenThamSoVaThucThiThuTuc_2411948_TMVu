using System;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Form khởi động: mở form của phần B và các form bài tập
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            new FoodForm().Show(this);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new OrdersForm().Show(this);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            new AccountForm().Show(this);
        }
    }
}
