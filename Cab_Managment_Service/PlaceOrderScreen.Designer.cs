namespace Cab_Managment_Service
{
    partial class PlaceOrderScreen
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
            this.label4 = new System.Windows.Forms.Label();
            this.goToConfirmScreenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationTextbox = new System.Windows.Forms.TextBox();
            this.backToAvailableDriverScreenBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.availableDriverDataGrid = new System.Windows.Forms.DataGridView();
            this.selectingDriverIdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selectingCarIdTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.availableCarDataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTextbox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.availableDriverDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableCarDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Do you want to confirm this order :";
            // 
            // goToConfirmScreenBtn
            // 
            this.goToConfirmScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToConfirmScreenBtn.Location = new System.Drawing.Point(620, 535);
            this.goToConfirmScreenBtn.Name = "goToConfirmScreenBtn";
            this.goToConfirmScreenBtn.Size = new System.Drawing.Size(161, 36);
            this.goToConfirmScreenBtn.TabIndex = 15;
            this.goToConfirmScreenBtn.Text = "Confirm";
            this.goToConfirmScreenBtn.UseVisualStyleBackColor = true;
            this.goToConfirmScreenBtn.Click += new System.EventHandler(this.goToConfirmScreenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Place Order";
            // 
            // locationTextbox
            // 
            this.locationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextbox.Location = new System.Drawing.Point(443, 451);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(427, 26);
            this.locationTextbox.TabIndex = 25;
            this.locationTextbox.TextChanged += new System.EventHandler(this.addressTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Location :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Destination :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // destinationTextbox
            // 
            this.destinationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationTextbox.Location = new System.Drawing.Point(443, 492);
            this.destinationTextbox.Name = "destinationTextbox";
            this.destinationTextbox.Size = new System.Drawing.Size(427, 26);
            this.destinationTextbox.TabIndex = 19;
            this.destinationTextbox.TextChanged += new System.EventHandler(this.firstNameTextbox_TextChanged);
            // 
            // backToAvailableDriverScreenBtn
            // 
            this.backToAvailableDriverScreenBtn.AutoSize = true;
            this.backToAvailableDriverScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAvailableDriverScreenBtn.Location = new System.Drawing.Point(12, 543);
            this.backToAvailableDriverScreenBtn.Name = "backToAvailableDriverScreenBtn";
            this.backToAvailableDriverScreenBtn.Size = new System.Drawing.Size(62, 42);
            this.backToAvailableDriverScreenBtn.TabIndex = 26;
            this.backToAvailableDriverScreenBtn.Text = "🔙";
            this.backToAvailableDriverScreenBtn.Click += new System.EventHandler(this.backToAvailableDriverScreenBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date (YYYY-MM-DD) :";
            // 
            // availableDriverDataGrid
            // 
            this.availableDriverDataGrid.AllowUserToAddRows = false;
            this.availableDriverDataGrid.AllowUserToDeleteRows = false;
            this.availableDriverDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableDriverDataGrid.Location = new System.Drawing.Point(613, 60);
            this.availableDriverDataGrid.Name = "availableDriverDataGrid";
            this.availableDriverDataGrid.ReadOnly = true;
            this.availableDriverDataGrid.Size = new System.Drawing.Size(417, 224);
            this.availableDriverDataGrid.TabIndex = 50;
            this.availableDriverDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableDriverDataGrid_CellContentClick);
            // 
            // selectingDriverIdTxt
            // 
            this.selectingDriverIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectingDriverIdTxt.Location = new System.Drawing.Point(762, 300);
            this.selectingDriverIdTxt.Name = "selectingDriverIdTxt";
            this.selectingDriverIdTxt.Size = new System.Drawing.Size(190, 26);
            this.selectingDriverIdTxt.TabIndex = 49;
            this.selectingDriverIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.selectingDriverIdTxt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(670, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Driver ID : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(733, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Available drivers";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // selectingCarIdTxt
            // 
            this.selectingCarIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectingCarIdTxt.Location = new System.Drawing.Point(308, 299);
            this.selectingCarIdTxt.Name = "selectingCarIdTxt";
            this.selectingCarIdTxt.Size = new System.Drawing.Size(190, 26);
            this.selectingCarIdTxt.TabIndex = 45;
            this.selectingCarIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.selectingCarIdTxt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Car ID : ";
            // 
            // availableCarDataGrid
            // 
            this.availableCarDataGrid.AllowUserToAddRows = false;
            this.availableCarDataGrid.AllowUserToDeleteRows = false;
            this.availableCarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableCarDataGrid.Location = new System.Drawing.Point(174, 60);
            this.availableCarDataGrid.Name = "availableCarDataGrid";
            this.availableCarDataGrid.ReadOnly = true;
            this.availableCarDataGrid.Size = new System.Drawing.Size(414, 224);
            this.availableCarDataGrid.TabIndex = 43;
            this.availableCarDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableCarDataGrid_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 24);
            this.label9.TabIndex = 41;
            this.label9.Text = "Available cars";
            // 
            // dateTextbox
            // 
            this.dateTextbox.CustomFormat = "yyyy-MM-dd hh:mm tt";
            this.dateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextbox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTextbox.Location = new System.Drawing.Point(443, 412);
            this.dateTextbox.Name = "dateTextbox";
            this.dateTextbox.Size = new System.Drawing.Size(427, 26);
            this.dateTextbox.TabIndex = 51;
            this.dateTextbox.Value = new System.DateTime(2024, 6, 9, 0, 56, 57, 0);
            // 
            // PlaceOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1155, 608);
            this.Controls.Add(this.dateTextbox);
            this.Controls.Add(this.availableDriverDataGrid);
            this.Controls.Add(this.selectingDriverIdTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectingCarIdTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.availableCarDataGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backToAvailableDriverScreenBtn);
            this.Controls.Add(this.locationTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destinationTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goToConfirmScreenBtn);
            this.Controls.Add(this.label1);
            this.Name = "PlaceOrderScreen";
            this.Text = "PlaceOrderScreen";
            this.Load += new System.EventHandler(this.PlaceOrderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableDriverDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableCarDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button goToConfirmScreenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox destinationTextbox;
        private System.Windows.Forms.Label backToAvailableDriverScreenBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView availableDriverDataGrid;
        private System.Windows.Forms.TextBox selectingDriverIdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selectingCarIdTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView availableCarDataGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTextbox;
    }
}