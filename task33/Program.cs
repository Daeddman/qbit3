/*using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());

        int n = 1;
        double sumN = 1.0;
        while (sumN >= x)
        {
            n++;
            sumN += 1.0 / n;
        }

        int m = 1;
        double sumM = 1.0;
        while (sumM <= x)
        {
            m++;
            sumM += 1.0 / m;
        }

        Console.WriteLine(n + " " + m);
    }
}*/
using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double n = 1, sum = 1;
        
        while (sum + 1 / (n + 1) < x)
        {
            n++;
            sum += 1 / n;
        }
        
        double m = 1;
        sum = 1;
        
        while (sum <= x )
        {
            m++;
            sum += 1.0 / m;
        }
        
        Console.WriteLine((int)Math.Floor(n) + " " + (int)Math.Ceiling(m));
    }
}