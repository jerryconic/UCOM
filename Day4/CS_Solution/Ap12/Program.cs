SayHello d1 = new SayHello(EnglishHello);

Greeting(d1);
Greeting(new SayHello(ChineseHello));
Greeting(delegate () { Console.WriteLine("你好"); });
Greeting(() => Console.WriteLine("你好"));
//Lambda運算式

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