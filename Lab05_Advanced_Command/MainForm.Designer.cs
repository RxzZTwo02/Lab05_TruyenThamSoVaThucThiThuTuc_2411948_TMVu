namespace Lab05_Advanced_Command
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFood = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(30, 20);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(200, 30);
            this.btnFood.TabIndex = 0;
            this.btnFood.Text = "Danh sách món ăn";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(30, 60);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 30);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Danh sách hóa đơn";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(30, 100);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(200, 30);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.Text = "Quản lý tài khoản";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 150);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnFood);
            this.Name = "MainForm";
            this.Text = "Chủ đề 5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAccounts;
    }
}
