/*
int x, y, total;
x = 10;
y = 20;
total = Add(x, y);
Console.WriteLine(total);
*/

Console.WriteLine(Add(10, 20));


int Add(int a, int b)
{
    Console.WriteLine($"Add:a={a}, b={b}");
    return a + b; 
}