using System;

class Program
{
    static void Main()
    {
        
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int P = int.Parse(input[1]);
        int M = int.Parse(input[2]);

        int years = 0;
        while (N < M)
        {
            N += (N * P) / 100; 
            years++;
        }

        Console.WriteLine(years);
    }
}