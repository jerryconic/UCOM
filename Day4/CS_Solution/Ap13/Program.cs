/*
Employee emp = new Employee { Id = 1, Name = "John", BirthDate = new DateTime(1990, 1, 1), Salary = 40000 };
Console.WriteLine(emp);
*/
List<Employee> lst = [
    new Employee { Id = 1, Name = "John", BirthDate = new DateTime(1990, 1, 1), Salary = 40000 },
    new Employee { Id = 2, Name = "Peter", BirthDate = new DateTime(1991, 1, 1), Salary = 46000 },
    new Employee { Id = 3, Name = "Linda", BirthDate = new DateTime(1992, 1, 1), Salary = 42000 },
    new Employee { Id = 4, Name = "Alice", BirthDate = new DateTime(1993, 1, 1), Salary = 38000 }
];
//foreach(Employee emp in lst)
//    Console.WriteLine(emp);
//LINQ Method
//var result = lst.Where<Employee>(p => p.Id == 3);
//var result = lst.Where<Employee>(p => p.Salary >= 40000);
//var result = lst.Where<Employee>(p => p.Name.ToUpper().Contains("A") );
//var result = lst.OrderBy(p => p.Salary);
var result = lst.Where<Employee>(p => p.Salary >= 40000).OrderByDescending(p => p.Salary);
foreach (var item in result)
    Console.WriteLine(item);

class Employee
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