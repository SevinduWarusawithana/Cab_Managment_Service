using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cab_Managment_Service
{
    public partial class PlaceOrderScreen : Form
    {
        public string username;
        protected string password;

        readonly string Vehicle_query = "SELECT * FROM Car WHERE Available_Car = 1";
        readonly string Driver_query = "SELECT * FROM Driver WHERE Available_Driver = 1";
        public PlaceOrderScreen(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrderScreen_Load(object sender, EventArgs e)
        {
            CustomerManager.ShowAvailableData(availableCarDataGrid, Vehicle_query);
            CustomerManager.ShowAvailableData(availableDriverDataGrid, Driver_query);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addressTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void goToConfirmScreenBtn_Click(object sender, EventArgs e)
        {
            if (selectingCarIdTxt.Text == "" || selectingDriverIdTxt.Text == "" || locationTextbox.Text == "" || destinationTextbox.Text == "")
            {
                MessageBox.Show("Please fill all the details");
            }
            else
            {
                try
                {
                    int customer_Id = CustomerManager.FetchId(username, password);
                    int driver_Id = int.Parse(selectingDriverIdTxt.Text);
                    int car_Id = int.Parse(selectingCarIdTxt.Text);
                    string date_time = dateTextbox.Text;
                    string location = locationTextbox.Text;
                    string destination = destinationTextbox.Text;

                    Order newOrder = new Order(0, customer_Id, driver_Id, car_Id, DateTime.Parse(date_time), location, destination);
                    int newId = CustomerManager.placeorder(newOrder);

                    if (newId > 0 && customer_Id > 0)
                    {
                        MessageBox.Show(" Successfully order added");
                        newOrder.OrderId = newId;
                    }
                    else
                    {
                        MessageBox.Show("Error Happened!");
                        newOrder = null;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    CustomerManager.ShowAvailableData(availableCarDataGrid, Vehicle_query);
                    CustomerManager.ShowAvailableData(availableDriverDataGrid, Driver_query);
                }
            }

            ConfirmationScreen screen = new ConfirmationScreen();
            screen.Show();
            this.Hide();
        }

        private void backToAvailableDriverScreenBtn_Click(object sender, EventArgs e)
        {
            customerDashboard screen = new customerDashboard(username, password);
            screen.Show();
            this.Hide();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            /*string location = locationTextbox.Text;
            string destination = destinationTextbox.Text;
            string date = dateTextbox.Text; // Convert date to string

            PlaceOrderClass orderManager = new PlaceOrderClass();
            orderManager.addMap(location, destination, date);*/
        }

        private void dateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void availableCarDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void availableDriverDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void selectCarBtn_Click(object sender, EventArgs e)
        {

        }

        private void selectDriverBtn_Click(object sender, EventArgs e)
        {

        }

        private void selectingCarIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void selectingDriverIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*private void availableCarDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerManager.ShowAvailableData(dataGridView1, Vehicle_query);
            CustomerManager.ShowAvailableData(dataGridView2, Driver_query);
        }*/
    }
}
