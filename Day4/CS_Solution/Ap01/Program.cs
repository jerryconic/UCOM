Person p1 = new Person("C001", "John");
p1.Display();
class Person
{
    private string _id, _name;
    public void Display()
    {
        Console.WriteLine($"Id={_id}, Name={_name}");
    }

    public Person(string id, string name)
    {
        _id = id;
        _name = name;
    }
}

