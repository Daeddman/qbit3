using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n = Math.Abs(n);
        int smallestDivisor = 2;
        
        if (n >= 2)
        {
            while (n % smallestDivisor != 0)
            {
                if (n % smallestDivisor == 0) break;
                smallestDivisor++;
               
            }
            Console.WriteLine(smallestDivisor);
        }

    }
}