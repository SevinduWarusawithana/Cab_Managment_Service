using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Managment_Service
{
    internal class Order
    {
        // aguements
        private int orderId;
        private int customerId;
        private int driverId;
        private int carId;
        private DateTime orderDate;
        private string location;
        private string destination;

        // constructor
        public Order(int orderId, int customerId, int driverId, int carId, DateTime orderDate, string location, string destination)
        {
            this.orderId = orderId;
            this.customerId = customerId;
            this.driverId = driverId;
            this.carId = carId;
            this.orderDate = orderDate;
            this.location = location;
            this.destination = destination;
        }

        //getters and setters
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int DriverId
        {
            get { return driverId; }
            set { driverId = value; }
        }

        public int CarId
        {
            get { return carId; }
            set { carId = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

    }
}
