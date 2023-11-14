using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int count = 0;
        
        N = Math.Abs(N);

        while (N > 0)
        {
            int digit = N % 10; 

            if (digit % 2 != 0)
            {
                count++;
            }

            N /= 10; 
        }

        Console.WriteLine(count);
    }
}