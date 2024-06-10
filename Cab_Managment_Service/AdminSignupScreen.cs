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
    public partial class AdminSignupScreen : Form
    {
        public AdminSignupScreen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backToLoginBtn10_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            if (adminNameTextBox.Text == "" || adminContactTextBox.Text == "" || labelusername.Text == "" || adminPasswordTextBox.Text == "" )
            {
                MessageBox.Show("Please fill all the fields");
            }
            else if (adminContactTextBox.Text.Length != 10)
            {
                MessageBox.Show("Contact number should be of 10 digits");
            }
            else
            {
                try
                {
                    string name = adminNameTextBox.Text;
                    string contact = adminContactTextBox.Text;
                    string username = adminUsernameTextBox.Text;
                    string password = adminPasswordTextBox.Text;

                    Admin admin = new Admin(0, name, contact, username, password);

                    int newId = AdminManager.addAdmin(admin);
                    if (newId > 0)
                    {
                        admin.UserId = newId;
                        MessageBox.Show("Successfully added admin");

                    }
                    else
                    {
                        admin = null;   
                        MessageBox.Show("Error happend!");
                    }
                }
                catch
                {

                }
                
            }
        }

        private void AdminSignupScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void adminContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void adminNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                // If the pressed key is not a letter, space, or control key, ignore it
                e.Handled = true;
            }
        }
    }
}
