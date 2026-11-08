namespace Lab05_Advanced_Command
{
    partial class FoodInfoForm
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
            this.lblFoodID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.cbbCatName = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            //
            // lblFoodID
            //
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Location = new System.Drawing.Point(20, 20);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(43, 13);
            this.lblFoodID.TabIndex = 0;
            this.lblFoodID.Text = "FoodID";
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            //
            // lblUnit
            //
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(20, 76);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Unit";
            //
            // lblCategoryName
            //
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(20, 104);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "CategoryName";
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            //
            // lblNotes
            //
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(20, 160);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes";
            //
            // txtFoodID
            //
            this.txtFoodID.Location = new System.Drawing.Point(120, 17);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(120, 20);
            this.txtFoodID.TabIndex = 6;
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(120, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 20);
            this.txtName.TabIndex = 7;
            //
            // txtUnit
            //
            this.txtUnit.Location = new System.Drawing.Point(120, 73);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(330, 20);
            this.txtUnit.TabIndex = 8;
            //
            // cbbCatName
            //
            this.cbbCatName.FormattingEnabled = true;
            this.cbbCatName.Location = new System.Drawing.Point(120, 101);
            this.cbbCatName.Name = "cbbCatName";
            this.cbbCatName.Size = new System.Drawing.Size(240, 21);
            this.cbbCatName.TabIndex = 9;
            //
            // btnAddNew
            //
            this.btnAddNew.Location = new System.Drawing.Point(370, 99);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(80, 23);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "Add &New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            //
            // nudPrice
            //
            this.nudPrice.Location = new System.Drawing.Point(120, 130);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(330, 20);
            this.nudPrice.TabIndex = 11;
            //
            // txtNotes
            //
            this.txtNotes.Location = new System.Drawing.Point(120, 157);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(330, 20);
            this.txtNotes.TabIndex = 12;
            //
            // btnAddFood
            //
            this.btnAddFood.Location = new System.Drawing.Point(150, 192);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 13;
            this.btnAddFood.Text = "&Add";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            //
            // btnUpdateFood
            //
            this.btnUpdateFood.Location = new System.Drawing.Point(240, 192);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFood.TabIndex = 14;
            this.btnUpdateFood.Text = "&Update";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(330, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // FoodInfoForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 232);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cbbCatName);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFoodID);
            this.Name = "FoodInfoForm";
            this.Text = "FoodInfoForm";
            this.Load += new System.EventHandler(this.FoodInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.ComboBox cbbCatName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnCancel;
    }
}
