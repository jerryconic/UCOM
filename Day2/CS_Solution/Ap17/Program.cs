using System.Diagnostics;
int n = 0;
for (; ; )
{
    Roll();
    n++;
    Console.Write("Press any key to continue...");
    //Console.ReadKey();
    Console.WriteLine(n); 
   
}



void Roll()
{
    Random rnd = new Random();
    int[] dices = new int[4];
    for (int i = 0; i < 4; i++)
        dices[i] = rnd.Next(1, 7);

    Array.Sort(dices);

    foreach (int n in dices)
        Console.Write($"{n} ");
    Console.WriteLine();

    if (dices[0] == dices[3])
    {
        Console.WriteLine("一色");
        Debugger.Break();
    }
    else if (dices[0] == dices[2] || dices[1] == dices[3])
        Console.WriteLine("沒點重擲(3)");
    else if (dices[0] == dices[1])
        Console.WriteLine($"{dices[2] + dices[3]}點");
    else if (dices[1] == dices[2])
        Console.WriteLine($"{dices[0] + dices[3]}點");
    else if (dices[2] == dices[3])
        Console.WriteLine($"{dices[0] + dices[1]}點");
    else
        Console.WriteLine("沒點重擲(1)");
}