string s;
int principal, n;
double rate;

Console.Write("本金:");
s = Console.ReadLine();
principal = int.Parse(s);

Console.Write("利率(%):");
s = Console.ReadLine();
rate = double.Parse(s);

Console.Write("期數:");
s = Console.ReadLine();
n = int.Parse(s);

Console.WriteLine("期數  本      金  利      息  小      計");
Console.WriteLine("====  ==========  ==========  ==========");
for (int i = 1; i <= n; i++)
{
    int interest = (int)(principal * rate / 100 + 0.5);
    Console.WriteLine($"{i,4}  {principal,10:#,##0}  {interest,10:#,##0}  {principal + interest,10:#,##0}");
    principal += interest;
}
Console.WriteLine("====  ==========  ==========  ==========");
