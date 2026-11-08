namespace Lab05_Advanced_Command
{
    partial class AccountForm
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
            this.components = new System.ComponentModel.Container();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTell = new System.Windows.Forms.Label();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.lvAccounts = new System.Windows.Forms.ListView();
            this.chAccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmViewRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewLog = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(12, 15);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(76, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Tên tài khoản:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(110, 12);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(240, 20);
            this.txtAccountName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 45);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 42);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(12, 75);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 13);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Vai trò:";
            // 
            // cbbRole
            // 
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(110, 72);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(150, 21);
            this.cbbRole.TabIndex = 5;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(266, 70);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(84, 25);
            this.btnAddRole.TabIndex = 6;
            this.btnAddRole.Text = "Thêm vai trò";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(380, 15);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(42, 13);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(450, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(298, 20);
            this.txtFullName.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(380, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(450, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // lblTell
            // 
            this.lblTell.AutoSize = true;
            this.lblTell.Location = new System.Drawing.Point(380, 75);
            this.lblTell.Name = "lblTell";
            this.lblTell.Size = new System.Drawing.Size(58, 13);
            this.lblTell.TabIndex = 11;
            this.lblTell.Text = "Điện thoại:";
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(450, 72);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(298, 20);
            this.txtTell.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(210, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.Location = new System.Drawing.Point(310, 108);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(120, 29);
            this.btnResetPassword.TabIndex = 15;
            this.btnResetPassword.Text = "Reset mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // lvAccounts
            // 
            this.lvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAccountName,
            this.chFullName,
            this.chEmail,
            this.chTell,
            this.chDateCreated});
            this.lvAccounts.ContextMenuStrip = this.cmsAccount;
            this.lvAccounts.FullRowSelect = true;
            this.lvAccounts.HideSelection = false;
            this.lvAccounts.Location = new System.Drawing.Point(12, 148);
            this.lvAccounts.MultiSelect = false;
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new System.Drawing.Size(736, 400);
            this.lvAccounts.TabIndex = 16;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAccounts.View = System.Windows.Forms.View.Details;
            this.lvAccounts.Click += new System.EventHandler(this.lvAccounts_Click);
            // 
            // chAccountName
            // 
            this.chAccountName.Text = "Tài khoản";
            this.chAccountName.Width = 120;
            // 
            // chFullName
            // 
            this.chFullName.Text = "Họ tên";
            this.chFullName.Width = 200;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 180;
            // 
            // chTell
            // 
            this.chTell.Text = "Điện thoại";
            this.chTell.Width = 110;
            // 
            // chDateCreated
            // 
            this.chDateCreated.Text = "Ngày tạo";
            this.chDateCreated.Width = 120;
            // 
            // cmsAccount
            // 
            this.cmsAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmViewRoles,
            this.tsmViewLog});
            this.cmsAccount.Name = "cmsAccount";
            this.cmsAccount.Size = new System.Drawing.Size(213, 48);
            // 
            // tsmViewRoles
            // 
            this.tsmViewRoles.Name = "tsmViewRoles";
            this.tsmViewRoles.Size = new System.Drawing.Size(212, 22);
            this.tsmViewRoles.Text = "Xem danh sách các vai trò";
            this.tsmViewRoles.Click += new System.EventHandler(this.tsmViewRoles_Click);
            // 
            // tsmViewLog
            // 
            this.tsmViewLog.Name = "tsmViewLog";
            this.tsmViewLog.Size = new System.Drawing.Size(212, 22);
            this.tsmViewLog.Text = "Xem nhật ký hoạt động";
            this.tsmViewLog.Click += new System.EventHandler(this.tsmViewLog_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 560);
            this.Controls.Add(this.lvAccounts);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.lblTell);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lblAccountName);
            this.Name = "AccountForm";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.cmsAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTell;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.ListView lvAccounts;
        private System.Windows.Forms.ColumnHeader chAccountName;
        private System.Windows.Forms.ColumnHeader chFullName;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chTell;
        private System.Windows.Forms.ColumnHeader chDateCreated;
        private System.Windows.Forms.ContextMenuStrip cmsAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmViewRoles;
        private System.Windows.Forms.ToolStripMenuItem tsmViewLog;
    }
}
