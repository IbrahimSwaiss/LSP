namespace EmployeeLib
{
    public class Employee : BaseEmployee, IAssignManager
    {
        public BaseEmployee AssignedManager { get; set; }

        public void AssignManager(BaseEmployee manager)
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
