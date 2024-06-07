using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Managment_Service
{
    internal abstract class Person
    {
        // aguements
        private int userId;
        private string userName;
        private string userContact;

        // constructor
        public Person(int userId, string userName, string userContact)
        {
            this.userId = userId;
            this.userName = userName;
            this.userContact = userContact;
        }

        // getters and setters
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string UserContact
        {
            get { return userContact; }
            set { userContact = value; }
        }

    }
}
