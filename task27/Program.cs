using System;

class Program
{
    static void Main(string[] args)
    {
        double costPerKilogram = double.Parse(Console.ReadLine());
        costPerKilogram = Math.Abs(costPerKilogram);

        for (int weight = 1; weight <= 15; weight ++)
        {
            double cost = (((costPerKilogram) * (weight*0.1)*10)/10);
            int hryvnia = (int)cost;
            int kopecks = (int)Math.Round(((cost - hryvnia) * 100));
            Console.WriteLine($"{weight*100,4}" + " grams: " + hryvnia + " UAH " + kopecks + " kop ");
        }
    }
}