using System.Collections;
/*
int[] ar = { 12, 34, 33, 25, 51 };
foreach(int n in ar)
    Console.WriteLine(n);
*/
/*
ArrayList lst = new ArrayList();
lst.Add(10);
lst.Add("ABCD");
lst.Add(DateTime.Today);
lst.Add(true);

lst.RemoveAt(1);
Console.WriteLine($"Count:{lst.Count}");
foreach(var obj in lst)
    Console.WriteLine(obj);
*/
int total = 0;
ArrayList lst = [10, 30, 40, 50, 60, "ABCD"];
foreach (var obj in lst)
{
    total += (int)obj;
    Console.WriteLine(obj);
}
Console.WriteLine($"Total:{total}");