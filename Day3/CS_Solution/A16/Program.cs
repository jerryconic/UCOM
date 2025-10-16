StreamReader rd = new StreamReader(@"D:\temp\test.txt");
string s = rd.ReadToEnd();
Console.WriteLine(s);
rd.Close();