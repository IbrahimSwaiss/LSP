using EmployeeLib.Abstract;

namespace EmployeeLib.Concrete
{
   public class Employee : BaseEmployee, IHasManager<Manager>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public Manager Manager { get; set; }

        public void AssignManager(Manager manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
