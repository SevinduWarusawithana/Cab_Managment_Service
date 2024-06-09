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
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            ConfirmationScreen logoutpage = new ConfirmationScreen();
            logoutpage.Show();
            this.Hide();
        }
    }
}
