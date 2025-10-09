for(; ; )
{
    int n = GetChoice();
    switch(n)
    {
        case 1:
            CalcTax();
            break;
        case 2:
            Exchange();
            break;
        case 3:
            Interest();
            break;
        case 0:
            Console.WriteLine("bye.");
            return;
        case -1:
            Console.WriteLine("僅接受0~3");
            break;
    }
    Console.Write("按任意鍵繼續...");
    Console.ReadKey();    
    Console.Clear();

}



int GetChoice()
{
    string s;
    Console.Write(@"
1.計算所得稅
2.匯率換算
3.計算利息
0.離開
請選擇:");
    s = Console.ReadLine();
    switch(s)
    {
        case "1":
            return 1;
        case "2":
            return 2;
        case "3":
            return 3;
        case "0":
            return 0;
        default:
            return -1;            
        }
}

void CalcTax()
{
    int income, tax;
    string s;

    Console.Write("輸入淨所得額:");
    s = Console.ReadLine();
    income = int.Parse(s);

    if (income <= 540000)
        tax = (int)(income * 0.05 + 0.5);
    else if (income <= 1210000)
        tax = (int)(income * 0.12 - 37800 + 0.5);
    else if (income <= 2420000)
        tax = (int)(income * 0.2 - 134600 + 0.5);
    else if (income <= 4530000)
        tax = (int)(income * 0.3 - 376600 + 0.5);
    else
        tax = (int)(income * 0.4 - 829600 + 0.5);

    Console.WriteLine($"淨所得額={income:#,##0}, 應納所得稅={tax:#,##0}");

}
void Exchange()
{
    string s, curr;
    int nt;
    decimal amount;

    Console.Write("台幣金額:");
    s = Console.ReadLine();
    nt = int.Parse(s);

    Console.Write("幣別(U=USD/E=EUR/J=JPY):");
    curr = Console.ReadLine();

    switch (curr)
    {
        case "U":
        case "u":
            amount = nt / 28.93M;
            break;
        case "J":
        case "j":
            amount = nt / 0.2048M;
            break;
        case "E":
        case "e":
            amount = nt / 34.05M;
            break;
        default:
            amount = 0;
            break;
    }

    Console.WriteLine($"NT={nt:#,##0}, 可兌換金額={amount:#,##0.00}");
}

void Interest()
{
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

}