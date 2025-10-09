
//local function

/*
 * void: 無回傳值
 * CalcTax: 函式名稱
 * (): 傳入參數(無)
 */
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




for (; ; )
{
    CalcTax();

    string s;
    Console.Write("是否再執行一次(Y/N)?");
    s = Console.ReadLine();
    if (s == "N" || s == "n") break; //continue;
    Console.Clear();
}
