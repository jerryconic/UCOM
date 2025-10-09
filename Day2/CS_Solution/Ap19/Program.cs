string s;
int a, b;
bool iscorrect;

do
{
    Console.Write("a=");
    s = Console.ReadLine();
    iscorrect = int.TryParse(s, out a);
    if(!iscorrect)//if(iscorrect==false)
        Console.WriteLine("a必須是數值");
} while (!iscorrect);//while(iscorrect == false)

do
{
    Console.Write("b=");
    s = Console.ReadLine();
    iscorrect=int.TryParse(s, out b);
    if (!iscorrect)//if(iscorrect==false)
        Console.WriteLine("b必須是數值");

} while (!iscorrect);
Console.WriteLine($"{a}+{b}={a + b}");
