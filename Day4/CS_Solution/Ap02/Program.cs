using System.Security.Cryptography;
using System.Xml.Linq;

Employee p1 = new Employee("C001", "John", "9541");
p1.Display();
p1.Say();
class Employee:Person
{
    private string _empid;
    public Employee(string id, string name, string empid):base(id, name) 
    { 
        _empid = empid;
    }
    public override void Display()
    {
        Console.WriteLine($"Id={_id}, Name={_name}, EmployeeID={_empid}");
    }

    public override void Say()
    {
        Console.WriteLine("Hello");
    }
}
abstract class Person
{
    protected string _id, _name;
    public abstract void Say();
    public virtual void Display()
    {
        Console.WriteLine($"Id={_id}, Name={_name}");
    }

    public Person(string id, string name)
    {
        _id = id;
        _name = name;
    }
    
    
}