string s;
int guess, ans;
Random rnd = new Random();
ans = rnd.Next(1, 100);

do
{
    Console.Write("猜數字(1~99):");
    s = Console.ReadLine();
    guess = int.Parse(s);

    if(guess == -1)
    {
        Console.WriteLine($"答案是:{ans}");
        break;
    }
    if(guess < 1 || guess > 99)
    {
        Console.WriteLine("請輸入1~99");
        continue;
    }

    if (guess < ans)
        Console.WriteLine("高一點");
    else if (guess > ans)
        Console.WriteLine("低一點");
    else
        Console.WriteLine("猜對了");
} while (ans !=guess);
