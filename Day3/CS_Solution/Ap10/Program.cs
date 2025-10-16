Console.WriteLine(Math.PI);
Console.WriteLine(Math.Sin(Math.PI/2));
Console.WriteLine(Math.Sin(Math.PI / 4));
Console.WriteLine(Math.Round(4.5, 0)); //Banker捨入法
Console.WriteLine(Math.Round(4.5, 0, MidpointRounding.AwayFromZero));

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Today.ToString("yyyy/MM/dd"));
DateTime d1 = DateTime.Now;
d1 = d1.AddYears(2);
Console.WriteLine(d1);
DateTime d2 = DateTime.Now;
Console.WriteLine((d1-d2).TotalDays);

string s = "ABCD";
Console.WriteLine(s[0]);
Console.WriteLine(s.ToLower());
if(s.StartsWith("A"))
    Console.WriteLine("Start A");
else
    Console.WriteLine("Not");

int n;

Console.WriteLine(s.Length);
