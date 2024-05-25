namespace Cab_Managment_Service
{
    partial class AvailableCarsScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.selectCarBtn = new System.Windows.Forms.Button();
            this.goToAvailableDriverScreenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backToCustomerDashboardBtn1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.selectingCarIdTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select a driver : ";
            // 
            // selectCarBtn
            // 
            this.selectCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCarBtn.Location = new System.Drawing.Point(538, 200);
            this.selectCarBtn.Name = "selectCarBtn";
            this.selectCarBtn.Size = new System.Drawing.Size(189, 35);
            this.selectCarBtn.TabIndex = 18;
            this.selectCarBtn.Text = "Selected this car";
            this.selectCarBtn.UseVisualStyleBackColor = true;
            // 
            // goToAvailableDriverScreenBtn
            // 
            this.goToAvailableDriverScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToAvailableDriverScreenBtn.Location = new System.Drawing.Point(423, 352);
            this.goToAvailableDriverScreenBtn.Name = "goToAvailableDriverScreenBtn";
            this.goToAvailableDriverScreenBtn.Size = new System.Drawing.Size(152, 35);
            this.goToAvailableDriverScreenBtn.TabIndex = 17;
            this.goToAvailableDriverScreenBtn.Text = "Go";
            this.goToAvailableDriverScreenBtn.UseVisualStyleBackColor = true;
            this.goToAvailableDriverScreenBtn.Click += new System.EventHandler(this.goToAvailableDriverScreenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Available car";
            // 
            // backToCustomerDashboardBtn1
            // 
            this.backToCustomerDashboardBtn1.AutoSize = true;
            this.backToCustomerDashboardBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToCustomerDashboardBtn1.Location = new System.Drawing.Point(23, 383);
            this.backToCustomerDashboardBtn1.Name = "backToCustomerDashboardBtn1";
            this.backToCustomerDashboardBtn1.Size = new System.Drawing.Size(62, 42);
            this.backToCustomerDashboardBtn1.TabIndex = 25;
            this.backToCustomerDashboardBtn1.Text = "🔙";
            this.backToCustomerDashboardBtn1.Click += new System.EventHandler(this.backToCustomerDashboardBtn1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(52, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(349, 233);
            this.dataGridView2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Car ID : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // selectingCarIdTxt
            // 
            this.selectingCarIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectingCarIdTxt.Location = new System.Drawing.Point(538, 149);
            this.selectingCarIdTxt.Name = "selectingCarIdTxt";
            this.selectingCarIdTxt.Size = new System.Drawing.Size(190, 26);
            this.selectingCarIdTxt.TabIndex = 29;
            this.selectingCarIdTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AvailableCarsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectingCarIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.backToCustomerDashboardBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectCarBtn);
            this.Controls.Add(this.goToAvailableDriverScreenBtn);
            this.Controls.Add(this.label1);
            this.Name = "AvailableCarsScreen";
            this.Text = "AvailableCarScreen";
            this.Load += new System.EventHandler(this.AvailableCarsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectCarBtn;
        private System.Windows.Forms.Button goToAvailableDriverScreenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backToCustomerDashboardBtn1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectingCarIdTxt;
    }
}