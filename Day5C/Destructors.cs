using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Destructors
{

    class First
    {
        public First()
        {
            Console.WriteLine("Base class first.");
        }
        ~First()
        {
            Console.WriteLine("First's destructor is called.");
        }
    }
    class Second : First
    {
        public Second()
        {
            Console.WriteLine("Base class for Third, derived for first.");
        }
        ~Second()
        {
            Console.WriteLine("Second's destructor is called.");
        }
    }
    class Third : Second
    {
        public Third()
        {
            Console.WriteLine("Derived for second.");
        }
        ~Third()
        {
            Console.WriteLine("Third's destructor is called.");
        }
    }

    class testDestructors
    {
        static void Main(string[] args)
        {
            Third c = new Third();
            Console.ReadLine();
        }
    }
}


