int[] numbers = { 17, 31, 42, 21, 5 };
int total = 0;

Array.Sort(numbers);

for(int i = 0; i<numbers.Length; i++)
{
    total += numbers[i];
    Console.WriteLine(numbers[i]);
}
/*
foreach(int n in numbers)
{
    total += n;
    Console.WriteLine(n);
}
*/
Console.WriteLine($"total={total}");

    