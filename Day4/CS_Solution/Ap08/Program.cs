Person p1 = new Person("C001", "John");
p1.Id = "XXXX";
Console.WriteLine(p1.Id);
p1.Display();

class Person
{
    private string _id, _name;
    public string Id { 
        get { return _id; }
        set { _id = value; }
    }
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
