using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter value a Number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= Num; i += 2)
            {
                sum += i;
            }
            Console.Write("Sum of Odd numbers from 1 to " + Num+ " is: " +sum);
            Console.ReadLine();
        }
    }
}
