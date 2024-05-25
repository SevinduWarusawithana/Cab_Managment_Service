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
    public partial class DriverManagementScreen : Form
    {
        public DriverManagementScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewDriverBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(addingDriverIdTxt.Text);
            string name = addingDriverNameTxt.Text;
            string phone = addingDriverContactTxt.Text;
            string availability = addingDriverAvailablityCombo.Text;

            DriverManagerClass driverManager = new DriverManagerClass();
            driverManager.addDriver(id, name, phone, true);
        }

        private void addingDriverAvailablityTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToAdminDashboardBtn2_Click(object sender, EventArgs e)
        {
            adminDashboard dashboard = new adminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void removeDriverBtn_Click(object sender, EventArgs e)
        {
            int driverId;

            if (int.TryParse(addingDriverIdTxt.Text, out driverId))
            {
                DriverManagerClass carManager = new DriverManagerClass();
                carManager.removeDriver(driverId);
            }
            else
            {
                MessageBox.Show("Please enter a valid car ID");
            }
        }
    }
}
