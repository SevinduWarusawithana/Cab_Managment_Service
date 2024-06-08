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
        private string name;
        private string password;

        //constructor
        public Customer(int userId, string name, string userContact, string userName, string password) : base(userId, userName, userContact)
        {
            this.Name = name;
            this.Password = password;
        }

        //getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
