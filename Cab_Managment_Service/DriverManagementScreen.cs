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

namespace Cab_Managment_Service
{
    public partial class DriverManagementScreen : Form
    {
        /*public DriverManagementScreen()
        {
            InitializeComponent();
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewDriverBtn_Click(object sender, EventArgs e)
        {
            if(addingDriverNameTxt.Text == "" || addingDriverContactTxt.Text == "" || addingDriverAvailablityCombo.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                string name = addingDriverNameTxt.Text;
                string phone = addingDriverContactTxt.Text;

                bool availability;

                if (addingDriverAvailablityCombo.Text == "true")
                {
                    availability = true;
                }
                else
                {
                    availability = false;
                }

                Driver driver = new Driver(0, name, phone, availability);

                int newid = DriverManagerClass.addDriver(driver);
                if (newid >= 0)
                {
                    MessageBox.Show("Driver added successfully! Driver ID: " + newid.ToString());
                    driver.UserId = newid;

                }
                else
                {
                    MessageBox.Show("Error adding driver");
                    driver = (null);
                }

                LoadDriverData();
            }
            

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
                DriverManagerClass.removeDriver(driverId);
                LoadDriverData();
            }
            else
            {
                MessageBox.Show("Please enter a valid car ID");
            }
        }


        public DriverManagementScreen()
        {
            InitializeComponent();
            LoadDriverData();
        }

        private void LoadDriverData()
        {
            DriverManagerGrid.DataSource = DriverManagerClass.GetAllDrivers();
        }

        private void viewDriverBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(addingDriverIdTxt.Text);
            DataTable dataTable = DriverManagerClass.getDriverDataById(id);
            DriverManagerGrid.DataSource = dataTable;
        }

        private void changeCarAvailabilityBtn_Click(object sender, EventArgs e)
        {

        }

        private void changeDriverAvailabilityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(addingDriverIdTxt.Text);
                string drvieravailable;

                if (addingDriverAvailablityCombo.SelectedItem != null && addingDriverAvailablityCombo.SelectedItem.ToString() == "true")
                {
                    drvieravailable = "1";
                }
                else
                {
                    drvieravailable = "0";
                }

                int state = AdminManager.ChangeAvailability(id, drvieravailable, "Driver");
                if (state > 0)
                {
                    MessageBox.Show("Availability updated successfully.");
                    LoadDriverData();

                }
                else
                {
                    MessageBox.Show("Error Happened Make Sure you enter the correct Driver ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addingDriverContactTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addingDriverContactTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addingDriverIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addingDriverNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                // If the pressed key is not a letter, space, or control key, ignore it
                e.Handled = true;
            }
        }
    }
}

