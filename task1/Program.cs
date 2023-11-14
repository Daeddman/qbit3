using System;

class Program
{
    static void Main()
    {
        int S = int.Parse(Console.ReadLine());

        for (int a = 1; a <= S; a++)
        {
            if (S % a == 0)
            {
                int b = S / a;

                if (a <= b)
                {
                    Console.WriteLine($"{a} {b}");
                }
            }
        }
    }
}