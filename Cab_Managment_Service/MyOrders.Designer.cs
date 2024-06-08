namespace Cab_Managment_Service
{
    partial class MyOrders
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
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backToCustomerDashboardBtn10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView
            // 
            this.myDataGridView.AllowUserToAddRows = false;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Location = new System.Drawing.Point(45, 91);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.ReadOnly = true;
            this.myDataGridView.Size = new System.Drawing.Size(713, 230);
            this.myDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "All my orders";
            // 
            // backToCustomerDashboardBtn10
            // 
            this.backToCustomerDashboardBtn10.AutoSize = true;
            this.backToCustomerDashboardBtn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToCustomerDashboardBtn10.Location = new System.Drawing.Point(31, 371);
            this.backToCustomerDashboardBtn10.Name = "backToCustomerDashboardBtn10";
            this.backToCustomerDashboardBtn10.Size = new System.Drawing.Size(62, 42);
            this.backToCustomerDashboardBtn10.TabIndex = 40;
            this.backToCustomerDashboardBtn10.Text = "🔙";
            this.backToCustomerDashboardBtn10.Click += new System.EventHandler(this.backToCustomerDashboardBtn10_Click);
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToCustomerDashboardBtn10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myDataGridView);
            this.Name = "MyOrders";
            this.Text = "MyOrders";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backToCustomerDashboardBtn10;
    }
}