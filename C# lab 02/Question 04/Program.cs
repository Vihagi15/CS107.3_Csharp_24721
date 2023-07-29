using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.Write( num + "is an Even Number");
                Console.ReadLine();
            }
            else
            {
                Console.Write(num + " is an Odd Number");
                Console.ReadLine();
            }
        }
    }
}
