string s;
int guess, ans, min=1, max=99;
Random rnd = new Random();
ans = rnd.Next(1, 100);

do
{
    Console.Write($"猜數字({min}~{max}):");
    s = Console.ReadLine();
    guess = int.Parse(s);

    if (guess == -1)
    {
        Console.WriteLine($"答案是:{ans}");
        break;
    }
    if (guess < min || guess > max)
    {
        Console.WriteLine($"請輸入{min}~{max}");
        continue;
    }

    if (guess < ans)
        min = guess + 1;
    else if (guess > ans)
        max = guess - 1;
    else
        Console.WriteLine("猜對了");
} while (ans != guess);
