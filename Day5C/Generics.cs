using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5C
{
    class Generics<T>
    {
        public Generics(T m)
        {
            Console.WriteLine(m);
        }
        public void display<T>(T ms)
        {
            Console.Write(ms);
        }
    }
    class testGen
    {
        static void Main(string[] args)
        {
            Generics<string> s = new Generics<string>("This is generic class");
            s.display("This is generic method");
            Console.ReadLine();
        }
    }
}
