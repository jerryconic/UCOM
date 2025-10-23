Person p1 = new Person();
p1.Id = "C001"; p1.Name = "John";
Console.WriteLine($"{p1.Id}-{p1.Name}");

Person p2 = new() { Id = "C002", Name = "Peter" };
p2.Display();

var obj = new { EmployeeID = 1, EmployeeName = "John", BirthDate = new DateTime(1990, 1, 1), salary = 40000 };

int[] ar = { 17, 31, 24, 21, 5 };

List<Person> list = [new Person { Id = "C003", Name = "John" },
    new Person { Id = "C004", Name = "Peter" },
    new Person { Id = "C005", Name = "Linda" },
    new Person { Id = "C006", Name = "Alice" },
];
foreach (Person p in list)
    p.Display();
class Person
{
    //自動實作屬性(Auto-Implement Properties)

    public string Id { get; set; }
    public string Name { get; set; }

    public void Display()
    {
        Console.WriteLine($"Id={Id}, Name={Name}");
    }
}