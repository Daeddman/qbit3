using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 1;
        int prevNumber = int.MinValue; 
        bool isNonDecreasing = true; 

        while (true)
        {
            string input = Console.ReadLine();
            if (input == null)
                break;

            int number = int.Parse(input);

            if (number < prevNumber)
            {
                isNonDecreasing = false;
                break; 
            }

            prevNumber = number;
            N++;
        }

        Console.WriteLine(N - 1); 
    }
}