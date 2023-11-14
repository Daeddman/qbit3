using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double reversedN = 0;
        bool leadingZeros = true;

        while (N != 0)
        {
            double digit = N % 10;
            
            if (leadingZeros && digit == 0)
            {
                N /= 10;
                continue;
            }
            
            reversedN = reversedN * 10 + digit;
            N /= 10;
            leadingZeros = false;
        }

        Console.WriteLine(reversedN);
    }
}