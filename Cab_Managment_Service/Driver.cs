using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Managment_Service
{
    internal class Driver : Person
    {
        // aguements
        private bool availability;

        // constructor
        public Driver(int userId, string userName, string userContact, bool availability) : base(userId, userName, userContact) 
        {
            this.availability = availability;
        }

        //change the availability of the driver
        public void ChangeAvailability(bool availability)
        {
            this.availability = availability;
        }

        //getters and setters
        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }
    }
}
