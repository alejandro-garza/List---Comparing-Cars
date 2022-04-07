using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ComparingCars.Classes
{
    public class Vehicle : Object
    {
        public int NumberOfWheels { get; set; }
        public string VinNumber { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ScreenSize { get; set; }

        // public string MPG { get; set; }
        // public string TankSize { get; set; }

        public void CallMom()
        {

        }

        public void StartEngine()
        {

        }

        public override bool Equals(object obj)
        {
            return this.Color == ((Vehicle)obj).Color;
        }

    }
}
