namespace Cab_Managment_Service
{
    partial class PlaceOrderScreen
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
            this.label4 = new System.Windows.Forms.Label();
            this.goToConfirmScreenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationTextbox = new System.Windows.Forms.TextBox();
            this.backToAvailableDriverScreenBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Do you want to confirm this order :";
            // 
            // goToConfirmScreenBtn
            // 
            this.goToConfirmScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToConfirmScreenBtn.Location = new System.Drawing.Point(453, 276);
            this.goToConfirmScreenBtn.Name = "goToConfirmScreenBtn";
            this.goToConfirmScreenBtn.Size = new System.Drawing.Size(161, 36);
            this.goToConfirmScreenBtn.TabIndex = 15;
            this.goToConfirmScreenBtn.Text = "Confirm";
            this.goToConfirmScreenBtn.UseVisualStyleBackColor = true;
            this.goToConfirmScreenBtn.Click += new System.EventHandler(this.goToConfirmScreenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Place Order";
            // 
            // locationTextbox
            // 
            this.locationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextbox.Location = new System.Drawing.Point(259, 121);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(427, 26);
            this.locationTextbox.TabIndex = 25;
            this.locationTextbox.TextChanged += new System.EventHandler(this.addressTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Location :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Destination :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // destinationTextbox
            // 
            this.destinationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationTextbox.Location = new System.Drawing.Point(259, 173);
            this.destinationTextbox.Name = "destinationTextbox";
            this.destinationTextbox.Size = new System.Drawing.Size(427, 26);
            this.destinationTextbox.TabIndex = 19;
            this.destinationTextbox.TextChanged += new System.EventHandler(this.firstNameTextbox_TextChanged);
            // 
            // backToAvailableDriverScreenBtn
            // 
            this.backToAvailableDriverScreenBtn.AutoSize = true;
            this.backToAvailableDriverScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAvailableDriverScreenBtn.Location = new System.Drawing.Point(21, 389);
            this.backToAvailableDriverScreenBtn.Name = "backToAvailableDriverScreenBtn";
            this.backToAvailableDriverScreenBtn.Size = new System.Drawing.Size(62, 42);
            this.backToAvailableDriverScreenBtn.TabIndex = 26;
            this.backToAvailableDriverScreenBtn.Text = "🔙";
            this.backToAvailableDriverScreenBtn.Click += new System.EventHandler(this.backToAvailableDriverScreenBtn_Click);
            // 
            // PlaceOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.backToAvailableDriverScreenBtn);
            this.Controls.Add(this.locationTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destinationTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goToConfirmScreenBtn);
            this.Controls.Add(this.label1);
            this.Name = "PlaceOrderScreen";
            this.Text = "PlaceOrderScreen";
            this.Load += new System.EventHandler(this.PlaceOrderScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button goToConfirmScreenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox destinationTextbox;
        private System.Windows.Forms.Label backToAvailableDriverScreenBtn;
    }
}