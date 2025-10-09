string s;
int n, total = 0;
do
{
    Console.Write("n(0 for end)=");
    s = Console.ReadLine();
    n = int.Parse(s);
    total += n;
    //break, continue
}
while (n != 0);
Console.WriteLine($"Total={total}");