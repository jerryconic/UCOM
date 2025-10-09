/*
short a = 10000;
int b;   

b = a;
Console.WriteLine($"a={a}, b={b}");
*/

int a = 1000000;
short b;

b = (short)a;
Console.WriteLine($"a={a}/{a:x8}, b={b}/{b:x4}");
