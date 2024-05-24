using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cab_Managment_Service
{
    public partial class OrdersScreen : Form
    {
        public OrdersScreen()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewOrderBtn_Click(object sender, EventArgs e)
        {

        }

        private void backToAdminDashboardBtn3_Click(object sender, EventArgs e)
        {
            adminDashboard dashboard = new adminDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
