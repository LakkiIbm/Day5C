using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Car
    {
        private string name;
        int num;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Car()
        {
            num = 100;
            Console.WriteLine(num);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Swift";
            Console.WriteLine(car.Name);
            Console.ReadLine();
        }
    }
}
