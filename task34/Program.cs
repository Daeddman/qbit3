using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        string numberStr = N.ToString();

        int frameWidth = 3;
        string horizontalLine = new string('*', frameWidth);

        Console.WriteLine(horizontalLine);

        foreach (char digit in numberStr)
        {
            Console.WriteLine($"*{digit}*");
        }

        Console.WriteLine(horizontalLine);
    }
}