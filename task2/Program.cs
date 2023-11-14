using System;

class Program
{
    static void Main()
    {
        int max = int.MinValue;
        int count = 0;

        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            if (number > max)
            {
                max = number;
                count = 1;
            }
            else if (number == max)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}