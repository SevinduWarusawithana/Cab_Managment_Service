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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void manageCarsBtn_Click(object sender, EventArgs e)
        {
            CarManagementScreen screen = new CarManagementScreen();
            screen.Show();
            this.Hide();
        }

        private void manageDriverBtn_Click(object sender, EventArgs e)
        {
            DriverManagementScreen screen = new DriverManagementScreen();
            screen.Show();
            this.Hide();
        }

        private void viewOrderBtn_Click(object sender, EventArgs e)
        {
            OrdersScreen screen = new OrdersScreen();
            screen.Show();
            this.Hide();
        }
    }
}
