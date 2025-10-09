string s;
int score;

//輸入成績
Console.Write("Score:");
s = Console.ReadLine();
score = int.Parse(s);

//判斷是否及格
if (score < 60) 
    Console.WriteLine("C-Class");
else if(score < 80)
    Console.WriteLine("B-Class");
else
    Console.WriteLine("A-Class");