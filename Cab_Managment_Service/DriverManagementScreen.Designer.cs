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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // removeDriverBtn
            // 
            this.removeDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDriverBtn.Location = new System.Drawing.Point(239, 354);
            this.removeDriverBtn.Name = "removeDriverBtn";
            this.removeDriverBtn.Size = new System.Drawing.Size(152, 35);
            this.removeDriverBtn.TabIndex = 9;
            this.removeDriverBtn.Text = "Remove driver";
            this.removeDriverBtn.UseVisualStyleBackColor = true;
            // 
            // viewDriverBtn
            // 
            this.viewDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDriverBtn.Location = new System.Drawing.Point(442, 69);
            this.viewDriverBtn.Name = "viewDriverBtn";
            this.viewDriverBtn.Size = new System.Drawing.Size(196, 30);
            this.viewDriverBtn.TabIndex = 8;
            this.viewDriverBtn.Text = "View selected driver";
            this.viewDriverBtn.UseVisualStyleBackColor = true;
            // 
            // addNewDriverBtn
            // 
            this.addNewDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewDriverBtn.Location = new System.Drawing.Point(50, 354);
            this.addNewDriverBtn.Name = "addNewDriverBtn";
            this.addNewDriverBtn.Size = new System.Drawing.Size(152, 35);
            this.addNewDriverBtn.TabIndex = 7;
            this.addNewDriverBtn.Text = "Add new driver";
            this.addNewDriverBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 264);
            this.textBox1.TabIndex = 6;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 105);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 229);
            this.textBox2.TabIndex = 10;
            // 
            // DriverManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.removeDriverBtn);
            this.Controls.Add(this.viewDriverBtn);
            this.Controls.Add(this.addNewDriverBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DriverManagementScreen";
            this.Text = "DriverManagementScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeDriverBtn;
        private System.Windows.Forms.Button viewDriverBtn;
        private System.Windows.Forms.Button addNewDriverBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}