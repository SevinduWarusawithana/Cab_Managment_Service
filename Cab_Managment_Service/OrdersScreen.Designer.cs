namespace Cab_Managment_Service
{
    partial class OrdersScreen
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
            this.backToAdminDashboardBtn3 = new System.Windows.Forms.Label();
            this.viewOrderDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders ";
            // 
            // backToAdminDashboardBtn3
            // 
            this.backToAdminDashboardBtn3.AutoSize = true;
            this.backToAdminDashboardBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToAdminDashboardBtn3.Location = new System.Drawing.Point(18, 389);
            this.backToAdminDashboardBtn3.Name = "backToAdminDashboardBtn3";
            this.backToAdminDashboardBtn3.Size = new System.Drawing.Size(62, 42);
            this.backToAdminDashboardBtn3.TabIndex = 24;
            this.backToAdminDashboardBtn3.Text = "🔙";
            this.backToAdminDashboardBtn3.Click += new System.EventHandler(this.backToAdminDashboardBtn3_Click);
            // 
            // viewOrderDataGrid
            // 
            this.viewOrderDataGrid.AllowUserToAddRows = false;
            this.viewOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOrderDataGrid.Location = new System.Drawing.Point(39, 77);
            this.viewOrderDataGrid.Name = "viewOrderDataGrid";
            this.viewOrderDataGrid.ReadOnly = true;
            this.viewOrderDataGrid.Size = new System.Drawing.Size(723, 242);
            this.viewOrderDataGrid.TabIndex = 25;
            this.viewOrderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewOrderDataGrid_CellContentClick);
            // 
            // OrdersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewOrderDataGrid);
            this.Controls.Add(this.backToAdminDashboardBtn3);
            this.Controls.Add(this.label1);
            this.Name = "OrdersScreen";
            this.Text = "OrdersScreen";
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backToAdminDashboardBtn3;
        private System.Windows.Forms.DataGridView viewOrderDataGrid;
    }
}