using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        int start, end, step;

        if (A < B)
        {
            start = A;
            end = B;
            step = 1;
        }
        else
        {
            start = A;
            end = B;
            step = -1;
        }

        int count = 0;
        for (int i = start; i != end + step; i += step)
        {
            count++;
        }
        Console.WriteLine($"{count} very important numbers:");
        for (int i = start; i != end + step; i += step)
        {
            Console.WriteLine(i);
        }

      
    }
}