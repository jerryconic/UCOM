int mn;
string s;

Console.Write("月份:");
s = Console.ReadLine();
mn = int.Parse(s);

switch(mn)
{
    //case block(case區塊)
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("大月(31天)");
        break;
        //break; return; goto;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("小月(30天)");
        break;

    case 2:
        Console.WriteLine("二月(28天或29天)");
        break;
    default:
        Console.WriteLine("僅接受1~12");
        break;
}    

if(mn == 1 || mn==3 || mn==5|| mn==7 || mn==8 
    || mn==10 || mn==12)
    Console.WriteLine("大月(31天)");
else if(mn==4 || mn==6 || mn==9 || mn==11)
    Console.WriteLine("小月(30天)");
else if(mn==2)
    Console.WriteLine("二月(28天或29天)");
else
    Console.WriteLine("僅接受1~12");