using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());
        
        int giftsToChildren = 0;
        int maxGiftsInBag = N;

        while (N > 1)
        {
         
            if (N % 2 == 0)
            {
                giftsToChildren += N / 2;
                N /= 2;
               
            }

            else
            {
                N = 3 * N + 1;
                maxGiftsInBag = Math.Max(maxGiftsInBag, N);
            }

            Console.WriteLine(N);
        }

        Console.WriteLine($"{giftsToChildren} {maxGiftsInBag}");
     
    }
}