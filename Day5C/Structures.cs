using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Book
{
    public string Name;
    public int Id;
    public void getData(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public void showValues()
    {
        Console.WriteLine("Name of the book: " + Name);
        Console.WriteLine("ID of the book: " + Id);
    }
}
class Structures
{
    static void Main(string[] args)
    {
        Book b1 = new Book();
        Book b2 = new Book();
        b1.getData("Twilight",10);
        b2.getData("Vampire Diaries", 20);
        Console.WriteLine("Details of 1st book:");
        b1.showValues();
        Console.WriteLine();
        Console.WriteLine("Details of 2nd book:");
        b2.showValues();
        Console.ReadLine();

    }
}

