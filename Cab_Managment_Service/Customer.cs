using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Managment_Service
{
    internal class Customer : Person
    {
        // aguemnets
        private string address;
        private string email;
        private string password;

        //constructor
        public Customer(int userId, string userName, string userContact, string address, string email, string password) : base(userId, userName, userContact)
        {
            this.address = address;
            this.email = email;
            this.password = password;
        }

        //getters and setters
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
