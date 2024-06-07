using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            string name = addingCarNameTxt.Text;
            string number = addingCarPlateNumberTxt.Text;

            bool availability;
            if (addingCarAvailablityCombo.Text == "True")
            {
                availability = true;
            }
            else
            {
                availability = false;
            }

            Vehicle vehicle = new Vehicle(0, name, number, availability);

            int newid = CarManagerClass.addCar(vehicle);
            if (newid >= 0)
            {
                MessageBox.Show("Car added successfully! Car ID: " + newid.ToString());
                vehicle.Vehicle_Id = newid;

            }
            else
            {
                MessageBox.Show("Error adding car");
                vehicle = (null);
            }
        }

        private void backToAdminDashboardBtn1_Click(object sender, EventArgs e)
        {
            adminDashboard dashboard = new adminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void removeCarBtn_Click(object sender, EventArgs e)
        {
            int carId;

            if (int.TryParse(addingCarIdTxt.Text, out carId))
            {
                CarManagerClass.removeCar(carId);
            }
            else
            {
                MessageBox.Show("Please enter a valid car ID");
            }
        }


    }
}
