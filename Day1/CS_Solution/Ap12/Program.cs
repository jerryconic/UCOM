string s;
int score;

//輸入成績
Console.Write("Score:");
s = Console.ReadLine();
score = int.Parse(s);

//判斷是否及格
if (score < 60) //if(condition) ==, >, <, !=(不等於), !(Not), &&(And), ||(Or)(pipe line)
    Console.WriteLine("不及格");
else
    Console.WriteLine("及格");

