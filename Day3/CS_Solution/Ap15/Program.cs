StreamWriter wr = new StreamWriter(@"D:\temp\test.txt");
/*
StreamWriter wr = new StreamWriter("C:\\temp\\test.txt");
StreamWriter wr = new StreamWriter("C:/temp/test.txt");
 */

for (int i = 0; i < 10; i++)
    wr.WriteLine("Hello world!");
wr.Close();
Console.WriteLine("執行完畢");