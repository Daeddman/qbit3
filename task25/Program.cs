using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        double product = 1.0;

        if (N >= 1 && N <= 20)
        {
            for (int i = 1; i <= N; i++)
            {
                product *= 1.0 + 0.1 * i;
            }
        }
        
        Console.WriteLine($"{product:F6}");
    }
}