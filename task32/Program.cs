using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int number = 1;

        while (count < n)
        {
            if (number % 3 == 1)
            {
                Console.Write($"{number} ");
                count++;
            }
            number++;
        }
    }
}