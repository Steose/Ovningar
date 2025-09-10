/* using System;

namespace DiceGame
{
    // Klassen Dice representerar en tärning
    public class Dice
    {
        private static Random random = new Random();

        // Metod som slår tärningen och returnerar ett tal mellan 1 och 6
        public static int Roll()
        {
            // Random.Next(start, end) ger ett heltal >= start och < end. 
            // Vi vill ha 1..6, därför använder vi Next(1, 7).
            // Metoden returnerar ett heltal som representerar resultatet av en tärningskast.
            // Random tar alltid emot ett startvärde och ett slutvärde. Man kan nöja sig med att bara skicka in ett värde också, då ser den det som att startvärdet är 0 och slutvärdet är det man skickat in.

            return random.Next(1, 7);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Skapa tre tärningar
            Dice[] dices = new Dice[3];
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new Dice();
            }

            int sum = 0;

            // Slå alla tärningar och summera resultaten
            for (int i = 0; i < dices.Length; i++)
            {
                int result = Dice.Roll();
                Console.WriteLine($"Tärning {i + 1}: {result}");
                sum += result;
            }

            // Visa summan
            Console.WriteLine($"Summan av alla tärningar är: {sum}");
        }

    }
}

 */

using System;

class Dice
{
    private static Random random = new Random();

    public int Roll()
    {
        // Returnerar ett slumpmässigt tal mellan 1 och 6 (inklusive).
        // Vi använder en statisk Random-instans för att undvika samma seed
        // när många Dice skapas snabbt efter varandra.
        // Random.Next(start, end) ger ett heltal >= start och < end.
        return random.Next(1, 7);
    }
}

class Program
{
    static void Main()
    {
        Dice dice = new Dice();
        int sum = 0;

        for (int i = 1; i <= 3; i++)
        {
            // Slå tärningen, visa resultatet och summera.
            int result = dice.Roll();
            Console.WriteLine($"Tärning {i}: {result}");
            sum += result;
        }

        Console.WriteLine($"Summan av tre tärningar är: {sum}");
    }
}