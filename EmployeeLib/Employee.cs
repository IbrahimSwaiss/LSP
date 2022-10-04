namespace EmployeeLib
{
    public class Employee : BaseEmployee, IAssignManager<Manager>
    {
        public Manager AssignedManager { get; set; }

        public void AssignManager(Manager manager)
        {
            AssignedManager = manager;
        }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
