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
        public string username;
        public string password;

        public customerDashboard(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
            
        } 

        private void customerDashboard_Load(object sender, EventArgs e)
        {

        }

        

        private void GoTo_Click(object sender, EventArgs e)
        {
            
        }

        private void backToLoginBtn2_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GoToPlaceOrderScreen_Click(object sender, EventArgs e)
        {
            PlaceOrderScreen screen = new PlaceOrderScreen(username, password);
            screen.Show();
            this.Hide();
        }

        private void viewMyOrdersBtn_Click(object sender, EventArgs e)
        {
            MyOrders screen = new MyOrders(username, password);
            screen.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }
    }
}
