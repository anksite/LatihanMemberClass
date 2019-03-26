using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass {

    class Program {

        static void Main(string[] args) {
            Taxi taxi = new Taxi();
            taxi.driverName = "Jono";
            taxi.onDuty = false;
            taxi.numPassenger = 10;

            taxi.taxiInfo();
            Console.WriteLine();
            taxi.pickUpPassenger();
            taxi.dropOfPassenger();

            Console.ReadKey();
        }

    }
}
