using System;

class Program
{
    static void Main()
    {
        int currentNumber = -1;
        int currentStreak = 0;  
        int maxStreak = 0;     

        while (true)
        {
            int number = int.Parse(Console.ReadLine()); 
            if (number == 0)
            {
                
                break;
            }

            if (number == currentNumber)
            {
                
                currentStreak++;
            }
            else
            {
               
                currentNumber = number;
                currentStreak = 1;
            }

            if (currentStreak > maxStreak)
            {
        
                maxStreak = currentStreak;
            }
        }

        Console.WriteLine(maxStreak);
    }
}