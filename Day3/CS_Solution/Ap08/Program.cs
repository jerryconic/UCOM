Person p1 = new Person("C001", "John");
p1.Id = "XXX";
p1.Display();
Console.WriteLine(p1.Id);
p1.Remarks = "Is a Person";
Console.WriteLine(p1.Remarks);
class Person
{
    //field, member variable(成員變數)
    private string _id, _name;

    //method(方法:操作類別的方法)
    public void Display()
    {
        Console.WriteLine($"Id:{_id}, Name:{_name}");
    }

    //Constructor(建構函式)
    public Person(string id, string name)
    {
        _id = id;
        _name = name;
    }

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Remarks { get; set; }


}