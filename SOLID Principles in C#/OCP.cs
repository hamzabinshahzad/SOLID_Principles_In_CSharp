using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_in_C_
{
    internal class OCP
    {
        // The goal is to make class and its required methods abstract so the we only need to implement new functionality by extending it with derived class instead of modifying the existing one.

        // Example: Make Employee class abstract so that the the bonus calculation is added to it seperately by extending class for each type of employee.
        public abstract class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Employee() { }

            public Employee(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public abstract decimal CalcBonus(decimal salary); // Each extending class will provide its own implementation
        }

        public class PermanentEmployee : Employee
        {
            public PermanentEmployee() { }

            public PermanentEmployee(int id, string name) : base(id, name) { }

            public override decimal CalcBonus(decimal salary)
            {
                return salary * 0.1M;
            }
        }

        public class TemporaryEmployee : Employee
        {
            public TemporaryEmployee() { }

            public TemporaryEmployee(int id, string name) : base(id, name) { }

            public override decimal CalcBonus(decimal salary)
            {
                return salary * 0.05M;
            }
        }



    }
}
