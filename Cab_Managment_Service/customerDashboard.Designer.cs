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
            this.viewAvailableCarBtn = new System.Windows.Forms.Button();
            this.viewAvailableDriverBtn = new System.Windows.Forms.Button();
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewAvailableCarBtn
            // 
            this.viewAvailableCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAvailableCarBtn.Location = new System.Drawing.Point(401, 121);
            this.viewAvailableCarBtn.Name = "viewAvailableCarBtn";
            this.viewAvailableCarBtn.Size = new System.Drawing.Size(161, 36);
            this.viewAvailableCarBtn.TabIndex = 9;
            this.viewAvailableCarBtn.Text = "View ";
            this.viewAvailableCarBtn.UseVisualStyleBackColor = true;
            // 
            // viewAvailableDriverBtn
            // 
            this.viewAvailableDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAvailableDriverBtn.Location = new System.Drawing.Point(401, 202);
            this.viewAvailableDriverBtn.Name = "viewAvailableDriverBtn";
            this.viewAvailableDriverBtn.Size = new System.Drawing.Size(161, 36);
            this.viewAvailableDriverBtn.TabIndex = 8;
            this.viewAvailableDriverBtn.Text = "View";
            this.viewAvailableDriverBtn.UseVisualStyleBackColor = true;
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderBtn.Location = new System.Drawing.Point(319, 285);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(161, 36);
            this.newOrderBtn.TabIndex = 7;
            this.newOrderBtn.Text = "New Order";
            this.newOrderBtn.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(230, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Available cars :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Available drivers :";
            // 
            // customerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewAvailableCarBtn);
            this.Controls.Add(this.viewAvailableDriverBtn);
            this.Controls.Add(this.newOrderBtn);
            this.Controls.Add(this.label1);
            this.Name = "customerDashboard";
            this.Text = "customerDashboard";
            this.Load += new System.EventHandler(this.customerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewAvailableCarBtn;
        private System.Windows.Forms.Button viewAvailableDriverBtn;
        private System.Windows.Forms.Button newOrderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}