int[] ar = { 17, 31, 42, 21, 5 };
int[] ar2;
//ar2 = ar;
ar2 = (int[])ar.Clone();
ar2[0] = -1;
ar2[1] = -1;

foreach (int n in ar)
    Console.WriteLine(n);

foreach (int n in ar2)
    Console.WriteLine(n);



