using System;

class Program
{
    static void Main()
    {
        string[] inputTime = Console.ReadLine().Split();
        int H = int.Parse(inputTime[0]);
        int M = int.Parse(inputTime[1]);

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{H:D2}:{M:D2}");
            M += 5;
            if (M >= 60)
            {
                M -= 60;
                H = (H + 1) % 24;
            }
        }
    }
}