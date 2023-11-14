using System;

class Program
{
    static void Main()
    {
        double n;
        double mid = 0;
        double mid2;
        double i;
        for (i = 0; i >= 0; i++)
        {
            
            n = double.Parse(Console.ReadLine());
            mid += n;
            if (n == 0)
                break;
                
        }

        mid2 = (mid / i);

        Console.WriteLine(mid2);
    }
}