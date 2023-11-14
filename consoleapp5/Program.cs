using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N * (N + 1) / 2];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int index = 0;

        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(numbers[index] + " ");
                index++;
            }
            Console.WriteLine();
        }
    }
}