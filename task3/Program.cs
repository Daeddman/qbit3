using System;

class Program
{
    static void Main()
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;

        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            if (number > max)
            {
                secondMax = max;
                max = number;
            }
            else if (number >= secondMax && number <= max)
            {
                secondMax = number;
            }
        }

        Console.WriteLine(secondMax);
    }
}