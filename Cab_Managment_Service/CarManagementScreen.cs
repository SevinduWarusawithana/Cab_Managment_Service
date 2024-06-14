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
        /*public CarManagementScreen()
        {
            InitializeComponent();
        }*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void addNewCarBtn_Click(object sender, EventArgs e)
        {
            if (addingCarNameTxt.Text == "" || addingCarPlateNumberTxt.Text == "" || addingCarAvailablityCombo.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                string name = addingCarNameTxt.Text;
                string number = addingCarPlateNumberTxt.Text;

                bool availability;
                if (addingCarAvailablityCombo.Text == "true")
                {
                    availability = true;
                }
                else
                {
                    availability = false;
                }

                Car car = new Car(0, name, number, availability);

                int newid = CarManagerClass.addCar(car);
                if (newid >= 0)
                {
                    MessageBox.Show("Car added successfully! Car ID: " + newid.ToString());
                    car.Car_Id = newid;

                }
                else
                {
                    MessageBox.Show("Car does not added");
                    //delete the object of the car
                    car = (null);
                }

                LoadCarData();

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
                LoadCarData();
            }
            else
            {
                MessageBox.Show("Please enter a valid car ID");
            }

        }

        public CarManagementScreen()
        {
            InitializeComponent();
            LoadCarData();
        }

        private void LoadCarData()
        {
            CarManagerGrid.DataSource = CarManagerClass.GetAllCars();
        }

        private void CarManagerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewCarBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(addingCarIdTxt.Text);
            DataTable dataTable = CarManagerClass.getCarDataById(id);
            CarManagerGrid.DataSource = dataTable;
        }

        private void changeCarAvailabilityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(addingCarIdTxt.Text);
                string caravailable;

                if (addingCarAvailablityCombo.SelectedItem != null && addingCarAvailablityCombo.SelectedItem.ToString() == "true")
                {
                    caravailable = "1";
                }
                else
                {
                    caravailable = "0";
                }

                int state = AdminManager.ChangeAvailability(id, caravailable, "Car");
                if (state > 0)
                {
                    MessageBox.Show(" Successfully updated availability.");
                    LoadCarData();

                }
                else
                {
                    MessageBox.Show("Error Happened! Please fill correct Car ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        

        private void addingCarIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addingCarNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                // If the pressed key is not a letter, space, or control key, ignore it
                e.Handled = true;
            }
        }
    }

}
