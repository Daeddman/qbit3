using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();

            for (int j = 0; j < m * 2; j++)
            {
                if (line[j * 2] == '1')
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}