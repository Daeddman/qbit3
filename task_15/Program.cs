using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split();

        int currentIndex = 0;

        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(numbers[currentIndex] + " ");
                currentIndex++;
            }
            Console.WriteLine();
        }
    }
}