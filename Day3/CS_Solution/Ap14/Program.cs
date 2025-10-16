List<Person> lst = [
    new Person{Id=1, Name="John", BirthDate=new DateTime(1990,1, 1), Salary=40000},
    new Person{Id=2, Name="Peter", BirthDate=new DateTime(1991,1, 1), Salary=46000},
    new Person{Id=3, Name="Linda", BirthDate=new DateTime(1992,1, 1), Salary=42000},
    new Person{Id=4, Name="Alice", BirthDate=new DateTime(1993,1, 1), Salary=38000}
    ];
//LINQ
var result = from p in lst
             where p.Salary >= 40000
             orderby p.Salary descending
             select p;

foreach(Person p in result)
    Console.WriteLine(p);

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public int Salary { get; set; }
    public override string ToString()
    {
        return $"Id={Id}, Name={Name}, BirthDate={BirthDate.ToString("yyyy-MM-dd")}, Salary={Salary}";
    }
}