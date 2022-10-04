using EmployeeLib.Abstract;
using System;

namespace EmployeeLib.Concrete
{
    public class Manager : BaseEmployee, IHasPerformance
    {
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
