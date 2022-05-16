namespace Galactica_silj4261
{
    enum PlanetType
    {
        Terrestial, Giant, Dwarf, Gas_Giant
    }
    internal class Star : SpaceObjects
    {
        public StarType Type { get; set; }
        public int Temperature { get; set; }

        List<Planet> Planet = new();
    }
}
