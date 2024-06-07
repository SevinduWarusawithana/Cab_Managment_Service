using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Managment_Service
{
    internal class Admin : Person
    {
        protected string password;

        public Admin(int userId, string userName, string userContact, string password) : base(userId, userName, userContact)
        {
            this.password = password;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
