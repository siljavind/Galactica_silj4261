namespace Galactica_silj4261
{
    enum PlanetType
    {
        Terrestial, Giant, Dwarf, Gas_Giant
    }

    internal class Star : SpaceObjects
    {
        public StarType StarType { get; set; }
        public int Temperature { get; set; }
        public Position position { get; }


        public List<Planet> Planets = new();


        public Star()
        {
            position = new();
        }
    }
}