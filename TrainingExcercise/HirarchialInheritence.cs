using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{

    using System;

    namespace YourNamespace  // Ensure this matches the namespace in Program.cs
    {
        // Base class Vehicle
        class Vehicle
        {
            public string Make;
            public string Model;

            // Method common to all vehicles
            public void Start()
            {
                Console.WriteLine("The " + Make + " " + Model + " is starting.");
            }

            public void Stop()
            {
                Console.WriteLine("The " + Make + " " + Model + " is stopping.");
            }
        }

        // Derived class Car (inherits from Vehicle)
        class Car : Vehicle
        {
            public int NumberOfDoors;

            // Car-specific method
            public void Honk()
            {
                Console.WriteLine("The " + Make + " " + Model + " is honking.");
            }

            public void OpenTrunk()
            {
                Console.WriteLine("Opening the trunk of the " + Make + " " + Model + ".");
            }
        }

        // Derived class Truck (inherits from Vehicle)
        class Truck : Vehicle
        {
            public int PayloadCapacity;

            // Truck-specific method
            public void LoadCargo()
            {
                Console.WriteLine("Loading cargo into the " + Make + " " + Model + " truck.");
            }

            public void DumpCargo()
            {
                Console.WriteLine("Dumping cargo from the " + Make + " " + Model + " truck.");
            }
        }

        // The Inheritance class which contains the Run method
        class HirarchialInheritance
        {
            // The Run method where the logic for hierarchical inheritance is executed
            public void Run()
            {
                // Create an object of the Car class
                Car car = new Car();
                car.Make = "Toyota";
                car.Model = "Corolla";
                car.NumberOfDoors = 4;

                // Calling methods from the Vehicle and Car classes
                car.Start();  // Inherited from Vehicle
                car.Honk();   // Specific to Car
                car.OpenTrunk();  // Specific to Car
                car.Stop();   // Inherited from Vehicle

                Console.WriteLine();  // Print an empty line for separation

                // Create an object of the Truck class
                Truck truck = new Truck();
                truck.Make = "Ford";
                truck.Model = "F-150";
                truck.PayloadCapacity = 2000;

                // Calling methods from the Vehicle and Truck classes
                truck.Start();  // Inherited from Vehicle
                truck.LoadCargo();  // Specific to Truck
                truck.DumpCargo();  // Specific to Truck
                truck.Stop();   // Inherited from Vehicle
            }
        }
    }

}
