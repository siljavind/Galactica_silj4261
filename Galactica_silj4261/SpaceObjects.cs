namespace Galactica_silj4261
{
    enum StarType
    {
        YellowDwarf, White, BlueNeutron, RedGiant
    }
    abstract class SpaceObjects // Abstract - can be inherited, but not instansiated
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; } //Could use ValueTuple

        class Position
        {
            public int PositionX { get; set; }
            public int PositionY { get; set; }

            public override string ToString()
            {
                return $"({PositionX},{PositionY})";
            }
        }

    }
}
