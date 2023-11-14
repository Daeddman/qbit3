using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                int nextNumber = int.Parse(Console.ReadLine());

                if (nextNumber == 0)
                {
                    break;
                }
                else
                {
                    sum += number; 
                    sum += nextNumber;
                }
            }
            else
            {
                sum += number;
            }
        }

        Console.WriteLine(sum);
    }
}