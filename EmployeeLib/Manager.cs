using System;

namespace EmployeeLib
{
    public class Manager : BaseEmployee, IAssignManager, IPerformance
    {
        public BaseEmployee AssignedManager { get; set; }

        public void AssignManager(BaseEmployee manager)
        {
            AssignedManager = manager;
        }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
