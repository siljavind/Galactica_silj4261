namespace Galactica_silj4261
{
    enum StarType
    {
        YellowDwarf, White, BlueNeutron, RedGiant
    }
    abstract class SpaceObjects // Abstract - can be inherited, but not instantiated
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position_ { get; set; } // Could use ValueTuple

        public class Position // TODO Nested ooor? 
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                return $"({X},{Y})";
            }
        }
    }

}
