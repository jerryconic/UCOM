string s;
int a, b;

Console.Write("a=");
//a = Console.ReadLine();
s = Console.ReadLine();
a = int.Parse(s);  //明確式型別轉換

Console.Write("b=");
s = Console.ReadLine();
b = int.Parse(s);  //明確式型別轉換

Console.WriteLine($"{a} + {b} = {a + b}");

