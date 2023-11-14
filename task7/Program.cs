using System;

class Program
{
    static void Main()
    {
        int previousNumber = int.MaxValue;

        int count = 0;
        while (true)
        {
            int number = int.Parse(Console.ReadLine());
           
            if (number == 0)
            {
                break; 
            }

            if (number > previousNumber)
            {
                count++;
            }

            previousNumber = number;
        }

        Console.WriteLine(count);
    }
}