using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split();
        int M = int.Parse(input[0]);
        int N = int.Parse(input[1]);

        for (int i = M; i <= N; i++)
        {
            double Ai = Math.Pow(-1,i-1) * (3 * i - 1);
            Console.Write($"{Ai} ");
        }
    }
}