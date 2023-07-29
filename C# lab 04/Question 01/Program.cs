using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //with parameter
            Console.WriteLine("Enter a distance in kilometers:");
            float distx = float.Parse(Console.ReadLine());
            ConvertValues newobj = new ConvertValues();
            newobj.kilometersToMeters2(distx);

            //with arameter and return type
            Console.WriteLine("Enter a distance in kilometers:");
            float disty = float.Parse(Console.ReadLine());
            ConvertValues newobj = new ConvertValues();
            float distM = newobj.kilometersToMeters3(disty);
            Console.WriteLine("the distance in kilometers:" + distM);


        }
    }
}
