using System;

class Program
{
    static void Main()
    {
        int max = int.MinValue;

        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            if (number > max)
            {
                max = number;
            }
           
        }

        Console.WriteLine(max);
    }
}