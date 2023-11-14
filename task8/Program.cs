using System;

class Program
{
    static void Main()
    {
        int n;
        int count = 0;
        for (int i = 1; i > 0; i++)
        {
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                break;
            if (n % 2 != 0)
                count++;
        }

        Console.WriteLine(count);
    }
}