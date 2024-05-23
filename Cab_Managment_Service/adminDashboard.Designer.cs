namespace Cab_Managment_Service
{
    partial class adminDashboard
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viewOrderBtn = new System.Windows.Forms.Button();
            this.manageDriverBtn = new System.Windows.Forms.Button();
            this.manageCarsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashborad ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 203);
            this.textBox1.TabIndex = 1;
            // 
            // viewOrderBtn
            // 
            this.viewOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderBtn.Location = new System.Drawing.Point(542, 236);
            this.viewOrderBtn.Name = "viewOrderBtn";
            this.viewOrderBtn.Size = new System.Drawing.Size(161, 36);
            this.viewOrderBtn.TabIndex = 2;
            this.viewOrderBtn.Text = "View Order";
            this.viewOrderBtn.UseVisualStyleBackColor = true;
            this.viewOrderBtn.Click += new System.EventHandler(this.viewOrderBtn_Click);
            // 
            // manageDriverBtn
            // 
            this.manageDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDriverBtn.Location = new System.Drawing.Point(542, 153);
            this.manageDriverBtn.Name = "manageDriverBtn";
            this.manageDriverBtn.Size = new System.Drawing.Size(161, 36);
            this.manageDriverBtn.TabIndex = 3;
            this.manageDriverBtn.Text = "Manage Drivers";
            this.manageDriverBtn.UseVisualStyleBackColor = true;
            this.manageDriverBtn.Click += new System.EventHandler(this.manageDriverBtn_Click);
            // 
            // manageCarsBtn
            // 
            this.manageCarsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCarsBtn.Location = new System.Drawing.Point(542, 72);
            this.manageCarsBtn.Name = "manageCarsBtn";
            this.manageCarsBtn.Size = new System.Drawing.Size(161, 36);
            this.manageCarsBtn.TabIndex = 4;
            this.manageCarsBtn.Text = "Manage Cars";
            this.manageCarsBtn.UseVisualStyleBackColor = true;
            this.manageCarsBtn.Click += new System.EventHandler(this.manageCarsBtn_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manageCarsBtn);
            this.Controls.Add(this.manageDriverBtn);
            this.Controls.Add(this.viewOrderBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "adminDashboard";
            this.Text = "adminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button viewOrderBtn;
        private System.Windows.Forms.Button manageDriverBtn;
        private System.Windows.Forms.Button manageCarsBtn;
    }
}