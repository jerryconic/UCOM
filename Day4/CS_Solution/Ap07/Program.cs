
using (Person p1 = new Person("C001", "John"))
{
    p1.Display();
}

class Person:IDisposable
{
    private string _id, _name;
    public void Display()
    {
        Console.WriteLine($"Id={_id}, Name={_name}");
    }

    public void Dispose()
    {
        Console.WriteLine($"{_id} is disposed.");
    }

    public Person(string id, string name)
    {
        _id = id;
        _name = name;
    }
}

