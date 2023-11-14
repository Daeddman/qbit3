using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int k = 0;

        while (Math.Pow(2, k) < N)
        {
            k++;
        }

        Console.WriteLine(k);
    }
}