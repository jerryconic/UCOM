int x=10, y=20;
Console.WriteLine("Before call:");
//Console.WriteLine($"x={x}, y={y}");
//Test(x, y);
//TestRef(ref x, ref y);
TestOut(out x, out y);
Console.WriteLine("After call:");
Console.WriteLine($"x={x}, y={y}");
void Test(int a, int b)
{
    a++;
    b++;
    Console.WriteLine($"a={a}, b={b}");
}

void TestRef(ref int a, ref int b)
{
    a++;
    b++;
    Console.WriteLine($"a={a}, b={b}");
}

void TestOut(out int a, out int b)
{
   
    a = 99;
    b = 999;
    Console.WriteLine($"a={a}, b={b}");
}