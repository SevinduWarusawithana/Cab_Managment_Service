﻿using System;
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
    public partial class PlaceOrderScreen : Form
    {
        public PlaceOrderScreen()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrderScreen_Load(object sender, EventArgs e)
        {

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
            ConfirmationScreen screen = new ConfirmationScreen();
            screen.Show();
            this.Hide();
        }

        private void backToAvailableDriverScreenBtn_Click(object sender, EventArgs e)
        {
            AvailableDriversScreen screen = new AvailableDriversScreen();
            screen.Show();
            this.Hide();
        }
    }
}
