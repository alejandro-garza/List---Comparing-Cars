using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ComparingCars.Classes
{
    public class Car : Vehicle
    {
        public int TrunkSize { get; set; }
        public int DoorCount { get; set; }
        public string Transmission { get; set; }

    }
}
