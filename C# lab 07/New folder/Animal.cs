using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07Q8
{
    internal class Animal
    {
        public void animal()
        {
            Console.WriteLine("I am an animal");
        }
    }
    internal class Dog:Animal
    {
        public void dog()
        {
            Console.WriteLine("I have four legs");
        }
    }
}
