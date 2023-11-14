using System;

class MainClass {
    public static void Main (string[] args) {
        int N = int.Parse(Console.ReadLine());
        int andreyScore = 0;
        int pashaScore = 0;
        int andreyPoint = 0;
        int pashaPoint = 0;

        for (int i = 0; i < N; i++) {
            string[] line = Console.ReadLine().Split();
            int andreyPoints = int.Parse(line[0]);
            int pashaPoints = int.Parse(line[1]);

            if (andreyPoints > pashaPoints) {
                andreyScore++;
                andreyPoint += andreyPoints;
            } else if (andreyPoints < pashaPoints) {
                pashaScore++;
                pashaPoint += pashaPoints;
            } else {
                andreyScore++;
                pashaScore++;
                andreyPoint += andreyPoints;
                pashaPoint += pashaPoints;
            }
        }

        if (andreyScore > pashaScore) {
            Console.WriteLine("Andrey");
        } else if (andreyScore < pashaScore) {
            Console.WriteLine("Pasha");
        } else if (andreyPoint > pashaPoint) {
            Console.WriteLine("Andrey");
        } else if (andreyPoint < pashaPoint) {
            Console.WriteLine("Pasha");
        } else {
            Console.WriteLine("Draw");
        }
    }
}