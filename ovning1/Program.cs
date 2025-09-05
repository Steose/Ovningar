namespace ovning1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double celsius = 100;
            double fahrenheit = CelsiusTillFahrenheit(celsius);
            Console.WriteLine($"{celsius} grader Celsius är {fahrenheit} grader Fahrenheit.");
        }

        public static double CelsiusTillFahrenheit(double celsius)
        {
            const double Multiplier = 9.0 / 5.0;   // tydlig konstant för multiplikatorn
            const double Offset = 32.0;            // tydlig konstant för förskjutningen

            if (double.IsNaN(celsius) || double.IsInfinity(celsius))
            {
                throw new ArgumentException("celsius måste vara ett ändligt tal.", nameof(celsius));
            }

            double fahrenheit = (celsius * Multiplier) + Offset;
            return fahrenheit;
        }
    }
}