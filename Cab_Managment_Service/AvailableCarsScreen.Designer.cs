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
            this.selectCarBtn = new System.Windows.Forms.Button();
            this.goToAvailbaleDriverBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectCarBtn
            // 
            this.selectCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCarBtn.Location = new System.Drawing.Point(328, 311);
            this.selectCarBtn.Name = "selectCarBtn";
            this.selectCarBtn.Size = new System.Drawing.Size(152, 35);
            this.selectCarBtn.TabIndex = 8;
            this.selectCarBtn.Text = "Selected this car";
            this.selectCarBtn.UseVisualStyleBackColor = true;
            // 
            // goToAvailbaleDriverBtn
            // 
            this.goToAvailbaleDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToAvailbaleDriverBtn.Location = new System.Drawing.Point(403, 367);
            this.goToAvailbaleDriverBtn.Name = "goToAvailbaleDriverBtn";
            this.goToAvailbaleDriverBtn.Size = new System.Drawing.Size(152, 35);
            this.goToAvailbaleDriverBtn.TabIndex = 7;
            this.goToAvailbaleDriverBtn.Text = "Go";
            this.goToAvailbaleDriverBtn.UseVisualStyleBackColor = true;
            this.goToAvailbaleDriverBtn.Click += new System.EventHandler(this.addNewCarBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 230);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Available cars";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select a driver :";
            // 
            // AvailableCarsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectCarBtn);
            this.Controls.Add(this.goToAvailbaleDriverBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AvailableCarsScreen";
            this.Text = "AvailableCarsScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectCarBtn;
        private System.Windows.Forms.Button goToAvailbaleDriverBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}