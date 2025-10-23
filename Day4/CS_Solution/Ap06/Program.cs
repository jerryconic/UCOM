List<Person> lst = [new Person("C001", "John"),
    new Person("C003", "Linda"),
    new Person("C004", "Alice"),
    new Person("C002", "Peter")];

lst.Sort();
foreach (Person p in lst)
    p.Display();

class Person:IComparable<Person>
{
    private string _id, _name;
    public void Display()
    {
        Console.WriteLine($"Id={_id}, Name={_name}");
    }

    public int CompareTo(Person? other)
    {
        if (other == null) 
            return 1;
        else
            return _id.CompareTo(other._id);

    }

    public Person(string id, string name)
    {
        _id = id;
        _name = name;
    }
}