using System;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backToAvailableCarsScreenBtn = new System.Windows.Forms.Label();
            this.selectingDriverIdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectDriverBtn
            // 
            this.selectDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDriverBtn.Location = new System.Drawing.Point(552, 190);
            this.selectDriverBtn.Name = "selectDriverBtn";
            this.selectDriverBtn.Size = new System.Drawing.Size(189, 35);
            this.selectDriverBtn.TabIndex = 13;
            this.selectDriverBtn.Text = "Selected this driver";
            this.selectDriverBtn.UseVisualStyleBackColor = true;
            // 
            // goToPlaceOrderScreenBtn
            // 
            this.goToPlaceOrderScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToPlaceOrderScreenBtn.Location = new System.Drawing.Point(414, 359);
            this.goToPlaceOrderScreenBtn.Name = "goToPlaceOrderScreenBtn";
            this.goToPlaceOrderScreenBtn.Size = new System.Drawing.Size(152, 35);
            this.goToPlaceOrderScreenBtn.TabIndex = 12;
            this.goToPlaceOrderScreenBtn.Text = "Go";
            this.goToPlaceOrderScreenBtn.UseVisualStyleBackColor = true;
            this.goToPlaceOrderScreenBtn.Click += new System.EventHandler(this.goToPlaceOrderScreenBtn_Click);
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
            this.label2.Location = new System.Drawing.Point(248, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Go to place order :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // backToAvailableCarsScreenBtn
            // 
            this.backToAvailableCarsScreenBtn.AutoSize = true;
            this.backToAvailableCarsScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAvailableCarsScreenBtn.Location = new System.Drawing.Point(19, 383);
            this.backToAvailableCarsScreenBtn.Name = "backToAvailableCarsScreenBtn";
            this.backToAvailableCarsScreenBtn.Size = new System.Drawing.Size(62, 42);
            this.backToAvailableCarsScreenBtn.TabIndex = 26;
            this.backToAvailableCarsScreenBtn.Text = "🔙";
            this.backToAvailableCarsScreenBtn.Click += new System.EventHandler(this.backToAvailableCarsScreenBtn_Click);
            // 
            // selectingDriverIdTxt
            // 
            this.selectingDriverIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectingDriverIdTxt.Location = new System.Drawing.Point(552, 140);
            this.selectingDriverIdTxt.Name = "selectingDriverIdTxt";
            this.selectingDriverIdTxt.Size = new System.Drawing.Size(190, 26);
            this.selectingDriverIdTxt.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Driver ID : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 232);
            this.dataGridView1.TabIndex = 33;
            // 
            // AvailableDriversScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectingDriverIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backToAvailableCarsScreenBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectDriverBtn);
            this.Controls.Add(this.goToPlaceOrderScreenBtn);
            this.Controls.Add(this.label1);
            this.Name = "AvailableDriversScreen";
            this.Text = "AvailableDriversScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button selectDriverBtn;
        private System.Windows.Forms.Button goToPlaceOrderScreenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label backToAvailableCarsScreenBtn;
        private System.Windows.Forms.TextBox selectingDriverIdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}