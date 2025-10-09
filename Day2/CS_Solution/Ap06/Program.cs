/*
string[] names = new string[5];

names[0] = "John";
names[1] = "Peter";
names[2] = "Linda";
names[3] = "Alice";
names[4] = "Nick";

for(int i = 0; i < names.Length; i++)
    Console.WriteLine(names[i]);
*/
//---------------------------------------

string[] names = { "John", "Peter", "Linda", "Alice", "Nick" };
//string[] names = [ "John", "Peter", "Linda", "Alice", "Nick" ];

foreach (string name in names)
    Console.WriteLine(name);