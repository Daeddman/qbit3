using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        int sumOfSquares = 0;

        if (A >= -100 & B >= A && B <= 100)
        {
            for (int i = A; i <= B; i++)
            {
                sumOfSquares += i * i;
            }
        }

        Console.WriteLine(sumOfSquares);
    }
}