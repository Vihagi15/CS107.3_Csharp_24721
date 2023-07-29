using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            int arraySize = Convert.ToInt32((Console.ReadLine()));

            array ArrayClass = new array(arraySize);

            ArrayClass.GetUserInputs();

            ArrayClass.DisplayArray();

            Console.ReadLine();
        }
    }
}
