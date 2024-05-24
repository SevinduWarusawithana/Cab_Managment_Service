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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addNewCarBtn = new System.Windows.Forms.Button();
            this.viewCarBtn = new System.Windows.Forms.Button();
            this.removeCarBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 273);
            this.textBox1.TabIndex = 1;
            // 
            // addNewCarBtn
            // 
            this.addNewCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCarBtn.Location = new System.Drawing.Point(45, 365);
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
            this.viewCarBtn.Location = new System.Drawing.Point(437, 65);
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
            this.removeCarBtn.Location = new System.Drawing.Point(239, 365);
            this.removeCarBtn.Name = "removeCarBtn";
            this.removeCarBtn.Size = new System.Drawing.Size(152, 35);
            this.removeCarBtn.TabIndex = 4;
            this.removeCarBtn.Text = "Remove car";
            this.removeCarBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(437, 106);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 231);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CarManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.removeCarBtn);
            this.Controls.Add(this.viewCarBtn);
            this.Controls.Add(this.addNewCarBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CarManagementScreen";
            this.Text = "CarManagementScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addNewCarBtn;
        private System.Windows.Forms.Button viewCarBtn;
        private System.Windows.Forms.Button removeCarBtn;
        private System.Windows.Forms.TextBox textBox2;
    }
}