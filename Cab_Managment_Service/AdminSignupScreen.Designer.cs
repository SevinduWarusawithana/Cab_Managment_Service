namespace Cab_Managment_Service
{
    partial class AdminSignupScreen
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
            this.addAdminBtn = new System.Windows.Forms.Button();
            this.adminNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminContactTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminUsernameTextBox = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backToLoginBtn10 = new System.Windows.Forms.Label();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addAdminBtn
            // 
            this.addAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdminBtn.Location = new System.Drawing.Point(547, 341);
            this.addAdminBtn.Name = "addAdminBtn";
            this.addAdminBtn.Size = new System.Drawing.Size(111, 34);
            this.addAdminBtn.TabIndex = 30;
            this.addAdminBtn.Text = "SignUp";
            this.addAdminBtn.UseVisualStyleBackColor = true;
            this.addAdminBtn.Click += new System.EventHandler(this.addAdminBtn_Click);
            // 
            // adminNameTextBox
            // 
            this.adminNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminNameTextBox.Location = new System.Drawing.Point(291, 139);
            this.adminNameTextBox.Name = "adminNameTextBox";
            this.adminNameTextBox.Size = new System.Drawing.Size(367, 26);
            this.adminNameTextBox.TabIndex = 29;
            this.adminNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminNameTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // adminContactTextBox
            // 
            this.adminContactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminContactTextBox.Location = new System.Drawing.Point(291, 184);
            this.adminContactTextBox.MaxLength = 10;
            this.adminContactTextBox.Name = "adminContactTextBox";
            this.adminContactTextBox.Size = new System.Drawing.Size(367, 26);
            this.adminContactTextBox.TabIndex = 32;
            this.adminContactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminContactTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Contact :";
            // 
            // adminUsernameTextBox
            // 
            this.adminUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUsernameTextBox.Location = new System.Drawing.Point(291, 230);
            this.adminUsernameTextBox.Name = "adminUsernameTextBox";
            this.adminUsernameTextBox.Size = new System.Drawing.Size(367, 26);
            this.adminUsernameTextBox.TabIndex = 34;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(129, 233);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(101, 20);
            this.labelusername.TabIndex = 33;
            this.labelusername.Text = "Username :";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpass.Location = new System.Drawing.Point(129, 282);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(96, 20);
            this.labelpass.TabIndex = 35;
            this.labelpass.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Create an account as admin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // backToLoginBtn10
            // 
            this.backToLoginBtn10.AutoSize = true;
            this.backToLoginBtn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLoginBtn10.Location = new System.Drawing.Point(41, 375);
            this.backToLoginBtn10.Name = "backToLoginBtn10";
            this.backToLoginBtn10.Size = new System.Drawing.Size(62, 42);
            this.backToLoginBtn10.TabIndex = 39;
            this.backToLoginBtn10.Text = "🔙";
            this.backToLoginBtn10.Click += new System.EventHandler(this.backToLoginBtn10_Click);
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPasswordTextBox.Location = new System.Drawing.Point(291, 276);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.Size = new System.Drawing.Size(367, 26);
            this.adminPasswordTextBox.TabIndex = 40;
            // 
            // AdminSignupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminPasswordTextBox);
            this.Controls.Add(this.backToLoginBtn10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.adminUsernameTextBox);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.adminContactTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAdminBtn);
            this.Controls.Add(this.adminNameTextBox);
            this.Controls.Add(this.label3);
            this.Name = "AdminSignupScreen";
            this.Text = "AdminSignupScreen";
            this.Load += new System.EventHandler(this.AdminSignupScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAdminBtn;
        private System.Windows.Forms.TextBox adminNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminUsernameTextBox;
        private System.Windows.Forms.Label labelusername;
        //private System.Windows.Forms.Label adminPasswordTextBox;
        private System.Windows.Forms.TextBox adminContactTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label backToLoginBtn10;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
    }
}