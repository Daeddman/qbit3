using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        int i = 0;

        while (i < 1000000)
        {
            i++;
            int j = 0;

            do
            {
                k++;
                j++;
                Console.Write($"{i} ");

                if (k == n)
                    goto m;
            } while (j < i);
        }
        m:;
    }
}