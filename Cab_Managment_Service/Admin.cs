using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Managment_Service
{
    internal class Admin : Person
    {
        // aguements
        protected string password;
        private string name;

        // constructor
        public Admin(int userId, string name, string userContact, string userName, string password) : base(userId, userName, userContact)
        {
            this.password = password;
            this.name = name;
        }

        //getters and setters
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
}
