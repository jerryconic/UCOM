List<float> lst = [12, 31, 42, 21, 5.5F];
float total = 0;
lst.Sort();
foreach(var n in lst)
{
    total += n;
    Console.WriteLine(n);
}
Console.WriteLine($"Total={total}");

