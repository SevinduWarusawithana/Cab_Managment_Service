namespace Cab_Managment_Service
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.customerLoginBtn = new System.Windows.Forms.Button();
            this.customerSignupBtn = new System.Windows.Forms.Button();
            this.adminSignupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(196, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(196, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(260, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please login to continue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(292, 140);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(295, 29);
            this.usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(292, 204);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(295, 29);
            this.passwordTextBox.TabIndex = 4;
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminLoginBtn.Location = new System.Drawing.Point(189, 275);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(192, 60);
            this.adminLoginBtn.TabIndex = 5;
            this.adminLoginBtn.Text = "Login as admin";
            this.adminLoginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.adminLoginBtn.UseVisualStyleBackColor = false;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // customerLoginBtn
            // 
            this.customerLoginBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLoginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerLoginBtn.Location = new System.Drawing.Point(416, 275);
            this.customerLoginBtn.Name = "customerLoginBtn";
            this.customerLoginBtn.Size = new System.Drawing.Size(183, 60);
            this.customerLoginBtn.TabIndex = 6;
            this.customerLoginBtn.Text = "Login as customer";
            this.customerLoginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.customerLoginBtn.UseVisualStyleBackColor = false;
            this.customerLoginBtn.Click += new System.EventHandler(this.customerLoginBtn_Click);
            // 
            // customerSignupBtn
            // 
            this.customerSignupBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerSignupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSignupBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerSignupBtn.Location = new System.Drawing.Point(416, 354);
            this.customerSignupBtn.Name = "customerSignupBtn";
            this.customerSignupBtn.Size = new System.Drawing.Size(183, 60);
            this.customerSignupBtn.TabIndex = 8;
            this.customerSignupBtn.Text = "Signup as customer";
            this.customerSignupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.customerSignupBtn.UseVisualStyleBackColor = false;
            this.customerSignupBtn.Click += new System.EventHandler(this.customerSignupBtn_Click);
            // 
            // adminSignupBtn
            // 
            this.adminSignupBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminSignupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSignupBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminSignupBtn.Location = new System.Drawing.Point(189, 354);
            this.adminSignupBtn.Name = "adminSignupBtn";
            this.adminSignupBtn.Size = new System.Drawing.Size(192, 60);
            this.adminSignupBtn.TabIndex = 7;
            this.adminSignupBtn.Text = "Signup as admin";
            this.adminSignupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.adminSignupBtn.UseVisualStyleBackColor = false;
            this.adminSignupBtn.Click += new System.EventHandler(this.adminSignupBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerSignupBtn);
            this.Controls.Add(this.adminSignupBtn);
            this.Controls.Add(this.customerLoginBtn);
            this.Controls.Add(this.adminLoginBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button adminLoginBtn;
        private System.Windows.Forms.Button customerLoginBtn;
        private System.Windows.Forms.Button customerSignupBtn;
        private System.Windows.Forms.Button adminSignupBtn;
    }
}

