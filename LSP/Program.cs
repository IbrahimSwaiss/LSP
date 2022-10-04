using System;
using EmployeeLib;

namespace LSP {
    internal class Program {
        static void Main(string[] args) {
            BaseEmployee accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            BaseEmployee emp = new CEO();

            emp.FirstName = "Tom";
            emp.LastName = "Lally";
            // emp.AssignManager(accountingVP); /// There is a compile error now when you try to assign manager for CEO
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
