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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addingCarIdTxt = new System.Windows.Forms.TextBox();
            this.addingCarNameTxt = new System.Windows.Forms.TextBox();
            this.addingCarPlateNumberTxt = new System.Windows.Forms.TextBox();
            this.backToAdminDashboardBtn1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addingCarAvailablityCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.addNewCarBtn.Location = new System.Drawing.Point(135, 264);
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
            this.viewCarBtn.Location = new System.Drawing.Point(835, 87);
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
            this.removeCarBtn.Location = new System.Drawing.Point(135, 328);
            this.removeCarBtn.Name = "removeCarBtn";
            this.removeCarBtn.Size = new System.Drawing.Size(152, 35);
            this.removeCarBtn.TabIndex = 4;
            this.removeCarBtn.Text = "Remove car";
            this.removeCarBtn.UseVisualStyleBackColor = true;
            this.removeCarBtn.Click += new System.EventHandler(this.removeCarBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(835, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 231);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Car ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Availability :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plate Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name : ";
            // 
            // addingCarIdTxt
            // 
            this.addingCarIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCarIdTxt.Location = new System.Drawing.Point(160, 95);
            this.addingCarIdTxt.Name = "addingCarIdTxt";
            this.addingCarIdTxt.Size = new System.Drawing.Size(232, 26);
            this.addingCarIdTxt.TabIndex = 10;
            // 
            // addingCarNameTxt
            // 
            this.addingCarNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCarNameTxt.Location = new System.Drawing.Point(160, 128);
            this.addingCarNameTxt.Name = "addingCarNameTxt";
            this.addingCarNameTxt.Size = new System.Drawing.Size(232, 26);
            this.addingCarNameTxt.TabIndex = 11;
            // 
            // addingCarPlateNumberTxt
            // 
            this.addingCarPlateNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCarPlateNumberTxt.Location = new System.Drawing.Point(160, 165);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 272);
            this.dataGridView1.TabIndex = 15;
            // 
            // addingCarAvailablityCombo
            // 
            this.addingCarAvailablityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCarAvailablityCombo.FormattingEnabled = true;
            this.addingCarAvailablityCombo.Location = new System.Drawing.Point(160, 197);
            this.addingCarAvailablityCombo.Name = "addingCarAvailablityCombo";
            this.addingCarAvailablityCombo.Size = new System.Drawing.Size(232, 26);
            this.addingCarAvailablityCombo.TabIndex = 23;
            // 
            // CarManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1084, 451);
            this.Controls.Add(this.addingCarAvailablityCombo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backToAdminDashboardBtn1);
            this.Controls.Add(this.addingCarPlateNumberTxt);
            this.Controls.Add(this.addingCarNameTxt);
            this.Controls.Add(this.addingCarIdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.removeCarBtn);
            this.Controls.Add(this.viewCarBtn);
            this.Controls.Add(this.addNewCarBtn);
            this.Controls.Add(this.label1);
            this.Name = "CarManagementScreen";
            this.Text = "CarManagementScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewCarBtn;
        private System.Windows.Forms.Button viewCarBtn;
        private System.Windows.Forms.Button removeCarBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addingCarIdTxt;
        private System.Windows.Forms.TextBox addingCarNameTxt;
        private System.Windows.Forms.TextBox addingCarPlateNumberTxt;
        private System.Windows.Forms.Label backToAdminDashboardBtn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox addingCarAvailablityCombo;
    }
}