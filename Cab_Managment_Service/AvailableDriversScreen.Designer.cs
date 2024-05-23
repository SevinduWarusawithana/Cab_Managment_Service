namespace Cab_Managment_Service
{
    partial class AvailableDriversScreen
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
            this.selectDriverBtn = new System.Windows.Forms.Button();
            this.goToPlaceOrderScreenBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectDriverBtn
            // 
            this.selectDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDriverBtn.Location = new System.Drawing.Point(314, 309);
            this.selectDriverBtn.Name = "selectDriverBtn";
            this.selectDriverBtn.Size = new System.Drawing.Size(189, 35);
            this.selectDriverBtn.TabIndex = 13;
            this.selectDriverBtn.Text = "Selected this driver";
            this.selectDriverBtn.UseVisualStyleBackColor = true;
            // 
            // goToPlaceOrderScreenBtn
            // 
            this.goToPlaceOrderScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToPlaceOrderScreenBtn.Location = new System.Drawing.Point(415, 371);
            this.goToPlaceOrderScreenBtn.Name = "goToPlaceOrderScreenBtn";
            this.goToPlaceOrderScreenBtn.Size = new System.Drawing.Size(152, 35);
            this.goToPlaceOrderScreenBtn.TabIndex = 12;
            this.goToPlaceOrderScreenBtn.Text = "Go";
            this.goToPlaceOrderScreenBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 230);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Available drivers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Go to place order :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AvailableDriversScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectDriverBtn);
            this.Controls.Add(this.goToPlaceOrderScreenBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AvailableDriversScreen";
            this.Text = "AvailableDriversScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectDriverBtn;
        private System.Windows.Forms.Button goToPlaceOrderScreenBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}