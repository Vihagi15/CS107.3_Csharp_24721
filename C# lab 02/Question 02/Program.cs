using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter the first number:");
            string number1 = Console.ReadLine();
            double num1 = Convert.ToDouble(number1);

            Console.WriteLine("Eneter the second number:");
            string number2 = Console.ReadLine();
            double num2 = Convert.ToDouble(number2);

            double add = num1 + num2;

            Console.WriteLine("Addition is " + add);
            double sub = num1 - num2;
            Console.WriteLine("Substraction is " + sub);
            double Multi = num1 * num2;
            Console.WriteLine("Multiplication is " + Multi);
            double div = num1 / num2;
            Console.WriteLine("Division is " + div);
            Console.ReadLine();
        }
    }
}
