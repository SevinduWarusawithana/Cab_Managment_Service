using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Managment_Service
{
    internal class Vehicle
    {
        // aguements
        private int vehicle_id;
        private string vehicle_name;
        private string vehicle_Plate;
        private bool vehicle_Availability;

        // constructor
        public Vehicle(int Vehicle_id, string Vehicle_name, string Vehicle_Plate, bool Vehicle_Availability)
        {
            vehicle_id = Vehicle_id;
            vehicle_name = Vehicle_name;
            vehicle_Plate = Vehicle_Plate;
            vehicle_Availability = Vehicle_Availability;
        }

        //getters and setters
        public int Vehicle_Id
        {
            get { return vehicle_id; }
            set { vehicle_id = value; }
        }

        public string Vehicle_Name
        {
            get { return vehicle_name; }
            set { vehicle_name = value; }
        }

        public string Vehicle_Plate
        {
            get { return vehicle_Plate; }
            set { vehicle_Plate = value; }
        }

        public bool Vehicle_Availability
        {
            get { return vehicle_Availability; }
            set { vehicle_Availability = value; }
        }
    }
}
