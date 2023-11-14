using System;

class Program
{
    static void Main()
    {
        int x = 0;
        int y = 0;
        int direction = 0;

        while (true)
        {
            string action = Console.ReadLine();
            if (action == null)
                break;

            char actionChar = action[0];

            if (actionChar == 'F')
            {
                
                if (direction == 0) y++; // Північ
                else if (direction == 1) x++; // Схід
                else if (direction == 2) y--; // Південь
                else if (direction == 3) x--; // Захід
            }
            else if (actionChar == 'L')
            {
         
                direction = (direction + 3) % 4;
            }
            else if (actionChar == 'R')
            {
               
                direction = (direction + 1) % 4; 
            }
        }

        Console.WriteLine(x + " " + y); 
    }
}