using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("Enter the first Number:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number:");
            Num2 = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = Num1 + Num2;
            Console.WriteLine("Sum of two Numbers:" + sum.ToString());
            Console.ReadLine();


        }
    }
}
