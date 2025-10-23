//2. d1 <=函式指標 指向 SayHello 函式
DelA d1 = new DelA(SayHello);

//4. 呼叫d1所指向的函式
d1();

//3. 定義SayHello 函式(函式簽章必須和delegate DelA相同)
void SayHello()
{
    Console.WriteLine("Hello");
}

//1. 定義delegate變數
delegate void DelA();