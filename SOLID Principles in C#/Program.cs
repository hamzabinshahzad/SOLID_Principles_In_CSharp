
//using static SOLID_Principles_in_C_.OCP;
//using static SOLID_Principles_in_C_.LSP;
using static SOLID_Principles_in_C_.DIP;
using System.Collections.Generic;

namespace SOLID_Principles_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // OCP: Following OCP guideline by allowing client to access orignal class with abstract interface/class.
            Employee emp1 = new PermanentEmployee(1, "Hamza");
            Employee emp2 = new TemporaryEmployee(2, "Shahbaz");
            */

            /*
            // LSP: Makeing Objects of subtype using super type so that the client does not know the specific subtype class
            List<IEmployee> employees = new List<IEmployee>(); 
            employees.Add(new PermanentEmployee(1, "Hamza"));
            employees.Add(new TemporaryEmployee(2, "Umer"));
            employees.Add(new ContractEmployee(3, "Qasim"));
            */

            /*
            // DIP: We will pass our engine type to the car externally via abstraction
            IEngine petrol = new PetrolEngine();
            Car hondaCivic = new Car(petrol);
            Car tesla = new Car(new ElectricEngine());
            hondaCivic.StartCar();
            tesla.StartCar();
            */
        }
    }
}
