using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        // n = Math.Abs(n);
        string binary = Convert.ToString(n, 2);
        int sum = 0;
        foreach (char digit in binary)
        {
            if (digit == '1') 
                sum++;
            
        }

        Console.WriteLine(sum);


    }
}