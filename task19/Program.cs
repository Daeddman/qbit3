using System;
class Program
{
    public static int FindMissingCard(int[] cardNumbers)
{
    int n = cardNumbers.Length + 1;
    int totalSum = n * (n + 1) / 2;
    int cardSum = 0;

    foreach (int number in cardNumbers)
    {
        cardSum += number;
    }

    return totalSum - cardSum;
}
    

    public static void Main(string[] args)

    {
    string[] input = Console.ReadLine().Split();
    int n = int.Parse(input[0]);
    int[] cardNumbers = new int[n - 1];

    for (int i = 0; i < n - 1; i++)
    {
        cardNumbers[i] = int.Parse(input[i + 1]);
    }

    int missingCard = FindMissingCard(cardNumbers);
    Console.WriteLine(missingCard);
    
    }
    
}