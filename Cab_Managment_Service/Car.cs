using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Managment_Service
{
    internal class Car
    {
        // aguements
        private int car_id;
        private string car_name;
        private string car_Plate;
        private bool car_Availability;

        // constructor
        public Car(int Car_id, string Car_name, string Car_Plate, bool Car_Availability)
        {
            car_id = Car_id;
            car_name = Car_name;
            car_Plate = Car_Plate;
            car_Availability = Car_Availability;
        }

        //getters and setters
        public int Car_Id
        {
            get { return car_id; }
            set { car_id = value; }
        }

        public string Car_Name
        {
            get { return car_name; }
            set { car_name = value; }
        }

        public string Car_Plate
        {
            get { return car_Plate; }
            set { car_Plate = value; }
        }

        public bool Car_Availability
        {
            get { return car_Availability; }
            set { car_Availability = value; }
        }
    }
}
