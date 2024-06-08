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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "" || passwordTextBox.Text == "" )
            {
                MessageBox.Show("Please enter all details"); 
                return;
            }
            else
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                if (UserAuthentication.authenticateUser(username, password, "Admin"))
                {
                    adminDashboard dashboard = new adminDashboard();
                    dashboard.Show();
                    this.Hide();
                }
            }
            
            
        }

        private void customerLoginBtn_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "" || passwordTextBox.Text == "" )
            {
                MessageBox.Show("Please enter all details"); 
                return;
            }
            else
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                if (UserAuthentication.authenticateUser(username, password, "Customer"))
                {
                    customerDashboard dashboard = new customerDashboard(username, password);
                    dashboard.Show();
                    this.Hide();
                }
            }
            

            
        }

        private void adminSignupBtn_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "" || passwordTextBox.Text == "" )
            {
                MessageBox.Show("Please enter all details"); 
                return;
            }
            else
            {
                AdminSignupScreen dashboard = new AdminSignupScreen();
                dashboard.Show();
                this.Hide();
            }
            
        }

        private void customerSignupBtn_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "" || passwordTextBox.Text == "" )
            {
                MessageBox.Show("Please enter all details"); 
                return;
            }
            else
            {
                CustomerSignupScreen dashboard = new CustomerSignupScreen();
                dashboard.Show();
                this.Hide();
            }
            
        }
    }
}
