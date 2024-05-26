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
    public partial class AvailableDriversScreen : Form
    {
        public AvailableDriversScreen()
        {
            InitializeComponent();
        }


        private void goToPlaceOrderScreenBtn_Click(object sender, EventArgs e)
        {
            PlaceOrderScreen screen = new PlaceOrderScreen();
            screen.Show();
            this.Hide();
        }

        private void backToAvailableCarsScreenBtn_Click(object sender, EventArgs e)
        {
            AvailableCarsScreen screen = new AvailableCarsScreen();
            screen.Show();
            this.Hide();
        }

        private void selectDriverBtn_Click(object sender, EventArgs e)
        {
            /*int id = int.Parse(selectingDriverIdTxt.Text);

            AvailabaleDriversClass driverManager = new AvailabaleDriversClass();
            driverManager.selectDriver(id);*/
        }
    }
}
