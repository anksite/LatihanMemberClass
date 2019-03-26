using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass {

    class Taxi {
        public string driverName    { get; set; }
        public Boolean onDuty       { get; set; }
        public int numPassenger     { get; set; }

        public void taxiInfo() {
            Console.WriteLine("Driver Name: {0}", driverName);

            Console.WriteLine("On Duty: {0}", onDuty ? "Yes" : "No");

            //if (onDuty) {
            //    Console.WriteLine("On Duty: Yes");
            //} else {
            //    Console.WriteLine("On Duty: No");
            //}

            Console.WriteLine("Num Passenger: {0}", numPassenger);
        }

        public void pickUpPassenger() {
            Console.WriteLine("{0} sedang menjemput penumpang", driverName);
        }

        public void dropOfPassenger() {
            Console.WriteLine("{0} sedang mengantar penumpang", driverName);
        }

    }
}
