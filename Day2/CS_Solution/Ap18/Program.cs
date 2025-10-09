string s;
int a, b;
try
{
    Console.Write("a=");
    s = Console.ReadLine();
    a = int.Parse(s);

    Console.Write("b=");
    s = Console.ReadLine();
    b = int.Parse(s);

    Console.WriteLine($"{a}+{b}={a + b}");

    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
    //throw;
}
