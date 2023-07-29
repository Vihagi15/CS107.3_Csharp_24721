using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the salary of the employee:");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the tax rate: ");
            double taxRatePercentage = Convert.ToDouble(Console.ReadLine());

            double taxRate= taxRatePercentage / 100;

            double taxAmount = salary * taxRate;

            double salaryAfterTax = salary - taxAmount;

            Console.WriteLine("The salary after tax is:" + salaryAfterTax );
        }  
    }
}
