namespace Cab_Managment_Service
{
    partial class DriverManagementScreen
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
            this.removeDriverBtn = new System.Windows.Forms.Button();
            this.viewDriverBtn = new System.Windows.Forms.Button();
            this.addNewDriverBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addingDriverContactTxt = new System.Windows.Forms.TextBox();
            this.addingDriverNameTxt = new System.Windows.Forms.TextBox();
            this.addingDriverIdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addingDriverNumberTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addingDriverAvailablityCombo = new System.Windows.Forms.ComboBox();
            this.backToAdminDashboardBtn2 = new System.Windows.Forms.Label();
            this.DriverManagerGrid = new System.Windows.Forms.DataGridView();
            this.changeDriverAvailabilityBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DriverManagerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // removeDriverBtn
            // 
            this.removeDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDriverBtn.Location = new System.Drawing.Point(143, 322);
            this.removeDriverBtn.Name = "removeDriverBtn";
            this.removeDriverBtn.Size = new System.Drawing.Size(152, 35);
            this.removeDriverBtn.TabIndex = 9;
            this.removeDriverBtn.Text = "Remove driver";
            this.removeDriverBtn.UseVisualStyleBackColor = true;
            this.removeDriverBtn.Click += new System.EventHandler(this.removeDriverBtn_Click);
            // 
            // viewDriverBtn
            // 
            this.viewDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDriverBtn.Location = new System.Drawing.Point(566, 117);
            this.viewDriverBtn.Name = "viewDriverBtn";
            this.viewDriverBtn.Size = new System.Drawing.Size(196, 35);
            this.viewDriverBtn.TabIndex = 8;
            this.viewDriverBtn.Text = "View selected driver";
            this.viewDriverBtn.UseVisualStyleBackColor = true;
            this.viewDriverBtn.Click += new System.EventHandler(this.viewDriverBtn_Click);
            // 
            // addNewDriverBtn
            // 
            this.addNewDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewDriverBtn.Location = new System.Drawing.Point(143, 268);
            this.addNewDriverBtn.Name = "addNewDriverBtn";
            this.addNewDriverBtn.Size = new System.Drawing.Size(152, 35);
            this.addNewDriverBtn.TabIndex = 7;
            this.addNewDriverBtn.Text = "Add new driver";
            this.addNewDriverBtn.UseVisualStyleBackColor = true;
            this.addNewDriverBtn.Click += new System.EventHandler(this.addNewDriverBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Driver Management Screen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addingDriverContactTxt
            // 
            this.addingDriverContactTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingDriverContactTxt.Location = new System.Drawing.Point(198, 163);
            this.addingDriverContactTxt.MaxLength = 10;
            this.addingDriverContactTxt.Name = "addingDriverContactTxt";
            this.addingDriverContactTxt.Size = new System.Drawing.Size(235, 24);
            this.addingDriverContactTxt.TabIndex = 20;
            this.addingDriverContactTxt.TextChanged += new System.EventHandler(this.addingDriverContactTxt_TextChanged);
            this.addingDriverContactTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addingDriverContactTxt_KeyPress);
            // 
            // addingDriverNameTxt
            // 
            this.addingDriverNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingDriverNameTxt.Location = new System.Drawing.Point(198, 112);
            this.addingDriverNameTxt.Name = "addingDriverNameTxt";
            this.addingDriverNameTxt.Size = new System.Drawing.Size(235, 24);
            this.addingDriverNameTxt.TabIndex = 19;
            this.addingDriverNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addingDriverNameTxt_KeyPress);
            // 
            // addingDriverIdTxt
            // 
            this.addingDriverIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingDriverIdTxt.Location = new System.Drawing.Point(703, 82);
            this.addingDriverIdTxt.Name = "addingDriverIdTxt";
            this.addingDriverIdTxt.Size = new System.Drawing.Size(235, 24);
            this.addingDriverIdTxt.TabIndex = 18;
            this.addingDriverIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addingDriverIdTxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name : ";
            // 
            // addingDriverNumberTxt
            // 
            this.addingDriverNumberTxt.AutoSize = true;
            this.addingDriverNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingDriverNumberTxt.Location = new System.Drawing.Point(46, 166);
            this.addingDriverNumberTxt.Name = "addingDriverNumberTxt";
            this.addingDriverNumberTxt.Size = new System.Drawing.Size(149, 20);
            this.addingDriverNumberTxt.TabIndex = 16;
            this.addingDriverNumberTxt.Text = "Contact Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Availablity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Driver ID :";
            // 
            // addingDriverAvailablityCombo
            // 
            this.addingDriverAvailablityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addingDriverAvailablityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingDriverAvailablityCombo.FormattingEnabled = true;
            this.addingDriverAvailablityCombo.Items.AddRange(new object[] {
            "true",
            "false"});
            this.addingDriverAvailablityCombo.Location = new System.Drawing.Point(198, 215);
            this.addingDriverAvailablityCombo.Name = "addingDriverAvailablityCombo";
            this.addingDriverAvailablityCombo.Size = new System.Drawing.Size(235, 26);
            this.addingDriverAvailablityCombo.TabIndex = 22;
            // 
            // backToAdminDashboardBtn2
            // 
            this.backToAdminDashboardBtn2.AutoSize = true;
            this.backToAdminDashboardBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAdminDashboardBtn2.Location = new System.Drawing.Point(22, 386);
            this.backToAdminDashboardBtn2.Name = "backToAdminDashboardBtn2";
            this.backToAdminDashboardBtn2.Size = new System.Drawing.Size(62, 42);
            this.backToAdminDashboardBtn2.TabIndex = 23;
            this.backToAdminDashboardBtn2.Text = "🔙";
            this.backToAdminDashboardBtn2.Click += new System.EventHandler(this.backToAdminDashboardBtn2_Click);
            // 
            // DriverManagerGrid
            // 
            this.DriverManagerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverManagerGrid.Location = new System.Drawing.Point(461, 166);
            this.DriverManagerGrid.Name = "DriverManagerGrid";
            this.DriverManagerGrid.Size = new System.Drawing.Size(477, 241);
            this.DriverManagerGrid.TabIndex = 24;
            // 
            // changeDriverAvailabilityBtn
            // 
            this.changeDriverAvailabilityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDriverAvailabilityBtn.Location = new System.Drawing.Point(776, 117);
            this.changeDriverAvailabilityBtn.Name = "changeDriverAvailabilityBtn";
            this.changeDriverAvailabilityBtn.Size = new System.Drawing.Size(162, 35);
            this.changeDriverAvailabilityBtn.TabIndex = 25;
            this.changeDriverAvailabilityBtn.Text = "Update Availability";
            this.changeDriverAvailabilityBtn.UseVisualStyleBackColor = true;
            this.changeDriverAvailabilityBtn.Click += new System.EventHandler(this.changeDriverAvailabilityBtn_Click);
            // 
            // DriverManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1063, 456);
            this.Controls.Add(this.changeDriverAvailabilityBtn);
            this.Controls.Add(this.DriverManagerGrid);
            this.Controls.Add(this.backToAdminDashboardBtn2);
            this.Controls.Add(this.addingDriverAvailablityCombo);
            this.Controls.Add(this.addingDriverContactTxt);
            this.Controls.Add(this.addingDriverNameTxt);
            this.Controls.Add(this.addingDriverIdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addingDriverNumberTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeDriverBtn);
            this.Controls.Add(this.viewDriverBtn);
            this.Controls.Add(this.addNewDriverBtn);
            this.Controls.Add(this.label1);
            this.Name = "DriverManagementScreen";
            this.Text = "DriverManagementScreen";
            ((System.ComponentModel.ISupportInitialize)(this.DriverManagerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeDriverBtn;
        private System.Windows.Forms.Button viewDriverBtn;
        private System.Windows.Forms.Button addNewDriverBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addingDriverContactTxt;
        private System.Windows.Forms.TextBox addingDriverNameTxt;
        private System.Windows.Forms.TextBox addingDriverIdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label addingDriverNumberTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addingDriverAvailablityCombo;
        private System.Windows.Forms.Label backToAdminDashboardBtn2;
        private System.Windows.Forms.DataGridView DriverManagerGrid;
        private System.Windows.Forms.Button changeDriverAvailabilityBtn;
    }
}