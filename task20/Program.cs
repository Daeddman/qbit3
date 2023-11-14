using System;

class Program
{
    static void Main()
    {
        int n;
        int sum = 0;
        for (int i = 1; i > 0; i++)
        {
            n = int.Parse(Console.ReadLine());
            sum += n;
            if (n == 0)
                break;
        }

        Console.WriteLine(sum);
    }
}