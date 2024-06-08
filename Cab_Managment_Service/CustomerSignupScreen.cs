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
    public partial class CustomerSignupScreen : Form
    {
        public CustomerSignupScreen()
        {
            InitializeComponent();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text == "" || customerContactTextBox.Text == "" || labelusername.Text == "" || customerPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else if (customerContactTextBox.Text.Length != 10)
            {
                MessageBox.Show("Contact number should be of 10 digits");
            }
            else
            {
                try
                {
                    string name = customerNameTextBox.Text;
                    string contact = customerContactTextBox.Text;
                    string username = customerUsernameTextBox.Text;
                    string password = customerPasswordTextBox.Text;

                    Customer customer = new Customer(0, name, contact, username, password);

                    int newId = CustomerManager.addCustomer(customer);
                    if (newId > 0)
                    {
                        customer.UserId = newId;
                        MessageBox.Show("customer added successfully");

                    }
                    else
                    {
                        customer = null;
                        MessageBox.Show("Error happend!");
                    }
                }
                catch
                {

                }

            }
        }

        private void backToLoginBtn11_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }

        private void customerContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void customerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                // If the pressed key is not a letter, space, or control key, ignore it
                e.Handled = true;
            }
        }
    }
}
