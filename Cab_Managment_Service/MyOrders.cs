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
    public partial class MyOrders : Form
    {
        public string username;
        protected string password;
        public MyOrders(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
            CustomerManager.LoadCustomerOrders(myDataGridView, username, password);
        }

        private void backToCustomerDashboardBtn10_Click(object sender, EventArgs e)
        {
            customerDashboard dashboard = new customerDashboard(username, password);
            dashboard.Show();
            this.Hide();
        }
    }
}
