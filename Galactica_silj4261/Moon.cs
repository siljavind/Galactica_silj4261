namespace Galactica_silj4261
{
    sealed class Moon : Planet // Sealed prevents other classes from inheriting
    {
        public Planet Orbiting { get; set; }

        public double Distance(Planet planet, Moon moon)
        {
            double distance = Math.Sqrt(Math.Pow(planet.position.X - planet.position.Y, 2) + Math.Pow(moon.position.X - moon.position.Y, 2));
            return distance;
        }
    }
}
