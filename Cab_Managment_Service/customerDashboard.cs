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
    public partial class customerDashboard : Form
    {
        public customerDashboard()
        {
            InitializeComponent();
        }

        private void customerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void viewAvailableCarBtn_Click(object sender, EventArgs e)
        {
            AvailableCarsScreen screen = new AvailableCarsScreen();
            screen.Show();
            this.Hide();
        }

        private void viewAvailableDriverBtn_Click(object sender, EventArgs e)
        {
            AvailableDriversScreen screen = new AvailableDriversScreen();
            screen.Show();
            this.Hide();
        }
    }
}
