using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Radius of the circle: ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radius * Radius;
            Console.WriteLine("Area of circle: " + Area);
            Console.ReadKey();
        }       
    }
}
