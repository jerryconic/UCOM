string s;
int a, b;

Console.Write("a=");
//a = Console.ReadLine();
s = Console.ReadLine();
int.TryParse(s, out a);

Console.Write("b=");
s = Console.ReadLine();
int.TryParse(s, out b);

Console.WriteLine($"{a} + {b} = {a + b}");

