using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Radius of the circle: ");
            double Radius = Convert.ToDouble(Console.ReadLine());

            double Area = Math.PI * Radius * Radius;
            Console.WriteLine("Area of the circle: " + Area);

            double circumference = 2 * Math.PI * Radius;
            Console.WriteLine("Cicumference of the circle: " + circumference);
            Console.ReadKey();
        }
    }
}
