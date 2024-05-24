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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select a driver : ";
            // 
            // selectCarBtn
            // 
            this.selectCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCarBtn.Location = new System.Drawing.Point(322, 309);
            this.selectCarBtn.Name = "selectCarBtn";
            this.selectCarBtn.Size = new System.Drawing.Size(189, 35);
            this.selectCarBtn.TabIndex = 18;
            this.selectCarBtn.Text = "Selected this car";
            this.selectCarBtn.UseVisualStyleBackColor = true;
            // 
            // goToAvailableDriverScreenBtn
            // 
            this.goToAvailableDriverScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToAvailableDriverScreenBtn.Location = new System.Drawing.Point(423, 371);
            this.goToAvailableDriverScreenBtn.Name = "goToAvailableDriverScreenBtn";
            this.goToAvailableDriverScreenBtn.Size = new System.Drawing.Size(152, 35);
            this.goToAvailableDriverScreenBtn.TabIndex = 17;
            this.goToAvailableDriverScreenBtn.Text = "Go";
            this.goToAvailableDriverScreenBtn.UseVisualStyleBackColor = true;
            this.goToAvailableDriverScreenBtn.Click += new System.EventHandler(this.goToAvailableDriverScreenBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 230);
            this.textBox1.TabIndex = 16;
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
            // AvailableCarsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectCarBtn);
            this.Controls.Add(this.goToAvailableDriverScreenBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AvailableCarsScreen";
            this.Text = "AvailableCarScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectCarBtn;
        private System.Windows.Forms.Button goToAvailableDriverScreenBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}