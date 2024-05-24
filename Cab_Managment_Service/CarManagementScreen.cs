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
    public partial class CarManagementScreen : Form
    {
        public CarManagementScreen()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewCarBtn_Click(object sender, EventArgs e)
        {

        }

        private void addNewCarBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(addingCarIdTxt.Text);
            string name = addingCarNameTxt.Text;
            string number = addingCarPlateNumberTxt.Text;
            string availability = addingCarAvailabilityTxt.Text;

            CarManagerClass carManager = new CarManagerClass();
            carManager.addCar(id, name, number, true);
        }

        private void backToAdminDashboardBtn1_Click(object sender, EventArgs e)
        {
            adminDashboard dashboard = new adminDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
