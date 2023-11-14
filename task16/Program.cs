using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N - i; j++)
            {
                Console.Write("  "); 
            }

            Console.Write("*");

            if (i > 1)
            {
                for (int j = 2; j <= i - 1; j++)
                {
                    Console.Write(" +");
                }
                Console.Write(" *");
            }

            Console.WriteLine();
        }

        for (int i = N - 1; i >= 1; i--)
        {
            for (int j = 1; j <= N - i; j++)
            {
                Console.Write("  ");
            }

            Console.Write("*");

            if (i > 1)
            {
                for (int j = 2; j <= i - 1; j++)
                {
                    Console.Write(" +");
                }
                Console.Write(" *");
            }

            Console.WriteLine();
        }
    }
}