
namespace SOLID_Principles_in_C_
{
    internal class LSP
    {
        // Liskov Substitution Principle involes extending the Open Closed Principle by imposing its own guidelines on top of OCP. OCP is a partial implementation of LSP
        // Example: Extending upon the OCP example if we extend the Employee class for a new type of employee say "ContractEmployee" then we would need to throw an exception for CalcBonus method because contract employees are not to be awarded with a bonus amount.
        public interface IEmployee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public interface IEmployeeBonus
        {
            public abstract decimal CalcBonus(decimal salary);
        }

        public abstract class Employee : IEmployee, IEmployeeBonus
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Employee() { }
            public Employee(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public abstract decimal CalcBonus(decimal salary);
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

        // Now for Contract employee we must implement this differently by using LSP, If we had implemented it using just OCP, we would have to throw an exception which is against LSP
        public class ContractEmployee : IEmployee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ContractEmployee() { }
            public ContractEmployee(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }


    }
}
