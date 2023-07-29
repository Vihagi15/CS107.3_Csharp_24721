using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab04Q1
{
    internal class ConvertValues
    {
        public void kilometersToMeters()

        {
            float distance = 0;

            Console.WriteLine("Enter a value in KM:");

            distance = float.Parse(Console.ReadLine());

            float disInMeters = distance * 1000;

            Console.WriteLine("The distance in meters: " + disInMeters);
        }

        public void kilometersToMeters2(float distancex) 
        {
            float disInMeters = distancex * 1000;
            Console.WriteLine("The distance in meters: " + disInMeters);
        }

        public float kilometersToMeters3(float distancex)
        {
            float disInMeters = distancex * 1000;
            return disInMeters;
        }

    }
}
