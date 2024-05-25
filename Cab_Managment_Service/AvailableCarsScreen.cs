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
    public partial class AvailableCarsScreen : Form
    {
        public AvailableCarsScreen()
        {
            InitializeComponent();
        }

        private void goToAvailableDriverScreenBtn_Click(object sender, EventArgs e)
        {
            AvailableDriversScreen screen = new AvailableDriversScreen();
            screen.Show();
            this.Hide();
        }

        private void backToCustomerDashboardBtn1_Click(object sender, EventArgs e)
        {
            customerDashboard screen = new customerDashboard();
            screen.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AvailableCarsScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
