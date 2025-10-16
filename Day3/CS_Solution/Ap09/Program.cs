using System.Runtime.CompilerServices;

Person p1 = new Person();
Person p2 = new Person();
Person p3 = new Person();
Console.WriteLine(Person.count);

public class Person
{
    private string _id, _name;
    public static int count=0;
    public Person()
    {
        count++;
    }
    public static void ShowCount()
    {
        
        Console.WriteLine(count);
    }

}