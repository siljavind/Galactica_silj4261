namespace Galactica_silj4261
{
    internal class Tools
    {
        public static int RandomPosition()
        {
            Random generator = new();
            int position = generator.Next(1000);

            return position;
        }

        public static void Print(Star star)
        {
            foreach (var planet in star.Planets)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{planet.Name} ({planet.PlanetType}) - distance from Sun: {planet.Distance(star, planet)}");

                if (planet.Moons.Any())
                {
                    foreach (var moon in planet.Moons)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine($"{moon.Name} - distance from {planet.Name}: {(int)moon.Distance(planet, moon)}");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
