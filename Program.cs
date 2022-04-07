using ComparingCars.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace ComparingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car telsa = new Car();

            telsa.Color = "Red";
            telsa.DoorCount = 4;
            telsa.Make = "Tesla";
            telsa.Model = "Model X";
            telsa.NumberOfWheels = 4;
            telsa.VinNumber = "VN58329483202";

            Car mustang = new Car();

            mustang.Color = "Blue";
            mustang.DoorCount = 4;
            mustang.Make = "Ford";
            mustang.Model = "Mustang";
            mustang.NumberOfWheels = 4;
            mustang.VinNumber = "VN58329483202";

            //Car terra = new Car();

            //mustang.Color = "Purple";
            //mustang.DoorCount = 4;
            //mustang.Make = "Nissan";
            //mustang.Model = "Xterra";
            //mustang.NumberOfWheels = 4;
            //mustang.VinNumber = "VN58329983202";

            Truck mack = new Truck();

            //mack.Color = "White";
            mack.Color = "Red";
            mack.TowingCapacity = "5000 pounds";
            mack.Model = "Mack Truck";
            mack.NumberOfWheels = 18;
            mack.VinNumber = "VN5835A832OE2";

            //Truck pickup = new Truck();

            //mack.Name = "PickUp Truck";
            //mack.Color = "Red";
            //mack.TowingCapacity = "1000 pounds";
            //mack.NumberOfWheels = 4;
            //mack.VinNumber = "VN5835A932OE2";

            Position walmart = new Position();
            walmart.Title = "Associate";

            List<Vehicle> myVehicles = new List<Vehicle>();
            List<Truck> myTrucks = new List<Truck>();

            myVehicles.Add(telsa);
            myVehicles.Add(mustang);
            //myVehicles.Add(terra);
            myVehicles.Add(mack);


            Console.WriteLine("--- List of Cars ---");
            foreach (var vehicle in myVehicles)
            {
                Console.WriteLine("Name: {0}", vehicle.Model);
                Console.WriteLine("Color: {0}", vehicle.Color);

                if (vehicle.Make != null)
                {
                    Console.WriteLine("Make: {0}", vehicle.Make);
                }

                string str = vehicle.Model;
                if (str.IndexOf("Truck") != -1)
                {
                    Console.WriteLine("TowingCapacity: {0}", mack.TowingCapacity);
                }

                vehicle.StartEngine();
                Console.WriteLine(" ");
            }


            Console.WriteLine("--- Comparing Cars and Colors ---");

            for (int i = 0; i < myVehicles.Count - 1; i++)
            {
                Console.WriteLine("{0}({1}) vs {2}({3})", myVehicles[i].Model, i+1, myVehicles[i + 1].Model, i+2);
                Console.WriteLine("{0}({1}) vs {2}({3})", myVehicles[i].Model, myVehicles[i].Color, myVehicles[i + 1].Model, myVehicles[i + 1].Color);
                Console.WriteLine(" ");
            }


            Console.WriteLine("--- Comparing Colors ---");

            for (int i = 0; i < myVehicles.Count; i++)
            {
                for (int j = i + 1; j < myVehicles.Count; j++)
                {
                    if (myVehicles[i].Color.Equals(myVehicles[j].Color))
                    {
                        Console.WriteLine("{0}({1}) have the same color as {2}({3})", myVehicles[i].Model, myVehicles[i].Color, myVehicles[j].Model, myVehicles[j].Color);
                    }
                    else
                    {
                        Console.WriteLine("{0}({1}) aren't the same color as {2}({3})", myVehicles[i].Model, myVehicles[i].Color, myVehicles[j].Model, myVehicles[j].Color);
                    }
                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("--- Comparing Colors (Override Vehicle.cs) ---");

            for (int i = 0; i < myVehicles.Count; i++)
            {
                for (int j = i + 1; j < myVehicles.Count; j++)
                {
                    if (myVehicles[i].Equals(myVehicles[j]))
                    {
                        Console.WriteLine("{0}({1}) have the same color as {2}({3})", myVehicles[i].Model, myVehicles[i].Color, myVehicles[j].Model, myVehicles[j].Color);
                    }
                    else
                    {
                        Console.WriteLine("{0}({1}) aren't the same color as {2}({3})", myVehicles[i].Model, myVehicles[i].Color, myVehicles[j].Model, myVehicles[j].Color);
                    }
                }

            }



            Console.ReadLine();

        }
    }
}
