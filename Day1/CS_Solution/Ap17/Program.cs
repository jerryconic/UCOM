for (int i = 0; i < 10; i++)
    Console.WriteLine(i);

/* 
 * 1.int i=0: 初始化設定(Initialization)
 * 2.i<10: 條件式(Condition)
 * 3.i++: 增(減)量(Increment, Decrement) i++, i--, i+=2, i-=3
 * 4. Console.WriteLine(i); 敍述句(Statement)
 * 
 */

Console.WriteLine("--------------");
for (int i = 0; i < 10; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("--------------");
for (int i = 10; i > 0; i--)
    Console.WriteLine(i);
