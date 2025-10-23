SayHello d1 = new SayHello(EnglishHello);
SayHello d2 = new SayHello(ChineseHello);

Greeting(d1);
Greeting(d2);

void Greeting(SayHello d)
{
    d();
}
void ChineseHello()
{
    Console.WriteLine("你好");
}
void EnglishHello()
{
    Console.WriteLine("Hello");
}

delegate void SayHello();