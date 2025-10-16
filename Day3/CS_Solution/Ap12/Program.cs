double x, y;
x = 10;
y = 20;
Console.Write("Before:");
Console.WriteLine($"x={x}, y={y}");
Swap<double>(ref x, ref y);
Console.Write("After:");
Console.WriteLine($"x={x}, y={y}");


//T: Template
void Swap<T>(ref T a, ref T b)
{
    T tmp = a;
    a = b;
    b = tmp;
}