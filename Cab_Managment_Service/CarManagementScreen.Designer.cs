namespace Cab_Managment_Service
{
    partial class CarManagementScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.addNewCarBtn = new System.Windows.Forms.Button();
            this.viewCarBtn = new System.Windows.Forms.Button();
            this.removeCarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addingCarIdTxt = new System.Windows.Forms.TextBox();
            this.addingCarNameTxt = new System.Windows.Forms.TextBox();
            this.addingCarPlateNumberTxt = new System.Windows.Forms.TextBox();
            this.backToAdminDashboardBtn1 = new System.Windows.Forms.Label();
            this.CarManagerGrid = new System.Windows.Forms.DataGridView();
            this.addingCarAvailablityCombo = new System.Windows.Forms.ComboBox();
            this.changeCarAvailabilityBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarManagerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Management Screen";
            // 
            // addNewCarBtn
            // 
            this.addNewCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCarBtn.Location = new System.Drawing.Point(164, 264);
            this.addNewCarBtn.Name = "addNewCarBtn";
            this.addNewCarBtn.Size = new System.Drawing.Size(152, 35);
            this.addNewCarBtn.TabIndex = 2;
            this.addNewCarBtn.Text = "Add new car";
            this.addNewCarBtn.UseVisualStyleBackColor = true;
            this.addNewCarBtn.Click += new System.EventHandler(this.addNewCarBtn_Click);
            // 
            // viewCarBtn
            // 
            this.viewCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCarBtn.Location = new System.Drawing.Point(629, 116);
            this.viewCarBtn.Name = "viewCarBtn";
            this.viewCarBtn.Size = new System.Drawing.Size(152, 35);
            this.viewCarBtn.TabIndex = 3;
            this.viewCarBtn.Text = "View selected car";
            this.viewCarBtn.UseVisualStyleBackColor = true;
            this.viewCarBtn.Click += new System.EventHandler(this.viewCarBtn_Click);
            // 
            // removeCarBtn
            // 
            this.removeCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCarBtn.Location = new System.Drawing.Point(164, 328);
            this.removeCarBtn.Name = "removeCarBtn";
            this.removeCarBtn.Size = new System.Drawing.Size(152, 35);
            this.removeCarBtn.TabIndex = 4;
            this.removeCarBtn.Text = "Remove car";
            this.removeCarBtn.UseVisualStyleBackColor = true;
            this.removeCarBtn.Click += new System.EventHandler(this.removeCarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Car ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Availability :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plate Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name : ";
            // 
            // addingCarIdTxt
            // 
            this.addingCarIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCarIdTxt.Location = new System.Drawing.Point(725, 84);
            this.addingCarIdTxt.Name = "addingCarIdTxt";
            this.addingCarIdTxt.Size = new System.Drawing.Size(232, 26);
            this.addingCarIdTxt.TabIndex = 10;
            this.addingCarIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addingCarIdTxt_KeyPress);
            // 
            // addingCarNameTxt
            // 
            this.addingCarNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCarNameTxt.Location = new System.Drawing.Point(189, 108);
            this.addingCarNameTxt.Name = "addingCarNameTxt";
            this.addingCarNameTxt.Size = new System.Drawing.Size(232, 26);
            this.addingCarNameTxt.TabIndex = 11;
            this.addingCarNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addingCarNameTxt_KeyPress);
            // 
            // addingCarPlateNumberTxt
            // 
            this.addingCarPlateNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCarPlateNumberTxt.Location = new System.Drawing.Point(189, 154);
            this.addingCarPlateNumberTxt.MaxLength = 10;
            this.addingCarPlateNumberTxt.Name = "addingCarPlateNumberTxt";
            this.addingCarPlateNumberTxt.Size = new System.Drawing.Size(232, 26);
            this.addingCarPlateNumberTxt.TabIndex = 12;
            // 
            // backToAdminDashboardBtn1
            // 
            this.backToAdminDashboardBtn1.AutoSize = true;
            this.backToAdminDashboardBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAdminDashboardBtn1.Location = new System.Drawing.Point(12, 392);
            this.backToAdminDashboardBtn1.Name = "backToAdminDashboardBtn1";
            this.backToAdminDashboardBtn1.Size = new System.Drawing.Size(62, 42);
            this.backToAdminDashboardBtn1.TabIndex = 14;
            this.backToAdminDashboardBtn1.Text = "🔙";
            this.backToAdminDashboardBtn1.Click += new System.EventHandler(this.backToAdminDashboardBtn1_Click);
            // 
            // CarManagerGrid
            // 
            this.CarManagerGrid.AllowUserToAddRows = false;
            this.CarManagerGrid.AllowUserToDeleteRows = false;
            this.CarManagerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarManagerGrid.Location = new System.Drawing.Point(490, 169);
            this.CarManagerGrid.Name = "CarManagerGrid";
            this.CarManagerGrid.ReadOnly = true;
            this.CarManagerGrid.Size = new System.Drawing.Size(467, 238);
            this.CarManagerGrid.TabIndex = 15;
            this.CarManagerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarManagerGrid_CellContentClick);
            // 
            // addingCarAvailablityCombo
            // 
            this.addingCarAvailablityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addingCarAvailablityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCarAvailablityCombo.FormattingEnabled = true;
            this.addingCarAvailablityCombo.Items.AddRange(new object[] {
            "true",
            "false"});
            this.addingCarAvailablityCombo.Location = new System.Drawing.Point(189, 197);
            this.addingCarAvailablityCombo.Name = "addingCarAvailablityCombo";
            this.addingCarAvailablityCombo.Size = new System.Drawing.Size(232, 26);
            this.addingCarAvailablityCombo.TabIndex = 23;
            // 
            // changeCarAvailabilityBtn
            // 
            this.changeCarAvailabilityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCarAvailabilityBtn.Location = new System.Drawing.Point(796, 116);
            this.changeCarAvailabilityBtn.Name = "changeCarAvailabilityBtn";
            this.changeCarAvailabilityBtn.Size = new System.Drawing.Size(162, 35);
            this.changeCarAvailabilityBtn.TabIndex = 24;
            this.changeCarAvailabilityBtn.Text = "Uptade Availability";
            this.changeCarAvailabilityBtn.UseVisualStyleBackColor = true;
            this.changeCarAvailabilityBtn.Click += new System.EventHandler(this.changeCarAvailabilityBtn_Click);
            // 
            // CarManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1057, 451);
            this.Controls.Add(this.changeCarAvailabilityBtn);
            this.Controls.Add(this.addingCarAvailablityCombo);
            this.Controls.Add(this.CarManagerGrid);
            this.Controls.Add(this.backToAdminDashboardBtn1);
            this.Controls.Add(this.addingCarPlateNumberTxt);
            this.Controls.Add(this.addingCarNameTxt);
            this.Controls.Add(this.addingCarIdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeCarBtn);
            this.Controls.Add(this.viewCarBtn);
            this.Controls.Add(this.addNewCarBtn);
            this.Controls.Add(this.label1);
            this.Name = "CarManagementScreen";
            this.Text = "CarManagementScreen";
            ((System.ComponentModel.ISupportInitialize)(this.CarManagerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewCarBtn;
        private System.Windows.Forms.Button viewCarBtn;
        private System.Windows.Forms.Button removeCarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addingCarIdTxt;
        private System.Windows.Forms.TextBox addingCarNameTxt;
        private System.Windows.Forms.TextBox addingCarPlateNumberTxt;
        private System.Windows.Forms.Label backToAdminDashboardBtn1;
        private System.Windows.Forms.DataGridView CarManagerGrid;
        private System.Windows.Forms.ComboBox addingCarAvailablityCombo;
        private System.Windows.Forms.Button changeCarAvailabilityBtn;
    }
}