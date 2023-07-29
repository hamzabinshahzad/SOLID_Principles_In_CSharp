using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_in_C_
{

    // Dependency Inversion Principle states that High level classes should NOT depend on low level classes, both should depend upon abstractions.
    // Abstractions should NOT depend on details, but details should depend on abstractions.
    // One and most common way to achieve DIP is through Dependency Injection.
    // DIP != Depedency Injection != Inversion Control

    /* High level and low level modules interact with each other via abstraction and that abstraction can be an interface! */
    internal class DIP
    {
        // Example: Suppose we have a Car class which can consist of either a Diesel, Petrol or Electric engine and all of these engine types have different low level starting mechanisms.
        
        // To make this work, we have to make high level (Car) and low level (Engine) module interact with each other via an abstraction (interface)
        public interface IEngine
        {
            void Start();
        }



        public class PetrolEngine : IEngine
        {
            public void Start()
            {
                Console.WriteLine("Injection petrol for fire....");
            }
        }

        public class DieselEngine : IEngine
        {
            public void Start()
            {
                Console.WriteLine("Pumping Diesel for ignition!");
            }
        }

        public class ElectricEngine : IEngine
        {
            public void Start()
            {
                Console.WriteLine("Linking with Batteries for power!");
            }
        }



        // Now, we will add and call low level module in high level module via our abstraction
        public class Car
        {
            // Need to define a private variable of abstraction type to hold the current state of incoming instance.
            private IEngine _engine;

            // Inject incoming instance of engine via abstraction.
            public Car(IEngine engine)
            {
                this._engine = engine;
            }

            public void StartCar() 
            {
                Console.WriteLine("Starting Car ------");
                _engine.Start();
                Console.WriteLine("Started Car -------");
            }

        }



    }
}
