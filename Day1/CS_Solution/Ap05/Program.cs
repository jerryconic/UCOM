/*
int a, b;
a = 10;
b = 20;
*/

string a, b;
a = "10";
b = "20";
Console.WriteLine($"{a} + {b} = {a+b}");
//字串插補(String Interpolate)

Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
//格式化字串(String Format)

string s2;  //字串  "ABCD"
char ch;    //字元  'A' '中' '文' '字'
ch = 'A';

long n0;  //-2^63 ~ 2^63-1 大約正負9.22X10^18
int n1;   //-2^31 ~ 2^31-1 大約正負21億 <==============
short n2; //-32768 ~ 32767
byte n3;  //0 ~ 255

bool b1;  //true, false

double n4; //15位有效位數
float n5;  //7位有效位數
decimal n6; //28位數


