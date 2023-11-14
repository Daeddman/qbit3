using System;

class Program
{
    static void Main()
    {
        int n;
        int sum = 0;
        int i;
        for (i = 0; i >= 0; i++)
        {
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                break;
        }

        Console.WriteLine(i);
    }
}