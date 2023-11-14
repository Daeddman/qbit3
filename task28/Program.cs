using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        
        if(A <= 100 && A >= 0 && B >=0 && B <= 99)
            for (int weight = 1; weight <= 10; weight++)
            {
                int costInKop = A * weight * 100 + B * weight;
                int costGrn = costInKop / 100;  
                int costKop = costInKop % 100;  

                Console.WriteLine($"{weight,3} kg: {costGrn,2},{costKop:D2} UAH");
            }
    }
}