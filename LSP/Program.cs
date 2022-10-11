using System;
using EmployeeLib;
using EmployeeLib.Abstract;
using EmployeeLib.Concrete;

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
            //emp.AssignManager(accountingVP); 
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
