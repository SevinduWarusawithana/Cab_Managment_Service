namespace Cab_Managment_Service
{
    partial class customerDashboard
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
            this.GoToPlaceOrderScreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backToLoginBtn2 = new System.Windows.Forms.Label();
            this.viewMyOrdersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoToPlaceOrderScreen
            // 
            this.GoToPlaceOrderScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPlaceOrderScreen.Location = new System.Drawing.Point(410, 248);
            this.GoToPlaceOrderScreen.Name = "GoToPlaceOrderScreen";
            this.GoToPlaceOrderScreen.Size = new System.Drawing.Size(161, 36);
            this.GoToPlaceOrderScreen.TabIndex = 7;
            this.GoToPlaceOrderScreen.Text = "Go";
            this.GoToPlaceOrderScreen.UseVisualStyleBackColor = true;
            this.GoToPlaceOrderScreen.Click += new System.EventHandler(this.GoToPlaceOrderScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Dashborad ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Place a new order :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "View my order :";
            // 
            // backToLoginBtn2
            // 
            this.backToLoginBtn2.AutoSize = true;
            this.backToLoginBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLoginBtn2.Location = new System.Drawing.Point(26, 382);
            this.backToLoginBtn2.Name = "backToLoginBtn2";
            this.backToLoginBtn2.Size = new System.Drawing.Size(62, 42);
            this.backToLoginBtn2.TabIndex = 24;
            this.backToLoginBtn2.Text = "🔙";
            this.backToLoginBtn2.Click += new System.EventHandler(this.backToLoginBtn2_Click);
            // 
            // viewMyOrdersBtn
            // 
            this.viewMyOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMyOrdersBtn.Location = new System.Drawing.Point(410, 150);
            this.viewMyOrdersBtn.Name = "viewMyOrdersBtn";
            this.viewMyOrdersBtn.Size = new System.Drawing.Size(161, 36);
            this.viewMyOrdersBtn.TabIndex = 25;
            this.viewMyOrdersBtn.Text = "Go";
            this.viewMyOrdersBtn.UseVisualStyleBackColor = true;
            this.viewMyOrdersBtn.Click += new System.EventHandler(this.viewMyOrdersBtn_Click);
            // 
            // customerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewMyOrdersBtn);
            this.Controls.Add(this.backToLoginBtn2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoToPlaceOrderScreen);
            this.Controls.Add(this.label1);
            this.Name = "customerDashboard";
            this.Text = "customerDashboard";
            this.Load += new System.EventHandler(this.customerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoToPlaceOrderScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label backToLoginBtn2;
        private System.Windows.Forms.Button viewMyOrdersBtn;
    }
}