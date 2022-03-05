using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Specifiers
{
    private string Name;
    private int empId;
    public void getData(string name, int id)
    {
        Name = name;
        empId = id;
    }
    public void showData()
    {
        Console.WriteLine("Name of the employee: " + Name);
        Console.WriteLine("Id of the employee: " + empId);
    }
}
class mainClass
{
    static void Main(string[] args)
    {
        Specifiers specs = new Specifiers();
        specs.getData("Lakshi", 10);
        specs.showData();
        Console.ReadLine();
    }
}

