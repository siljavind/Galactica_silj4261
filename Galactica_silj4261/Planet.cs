namespace Galactica_silj4261
{
    internal class Planet : SpaceObjects
    {
        public int Diameter { get; set; } // In meters 
        public int RotationPeriod { get; set; } // In hours
        public int RevolutionPeriod { get; set; } // In days

        List<Moon> Moon = new();

        void Distance(int x_1, int x_2, int y_1, int y_2) // TODO Cleanup on aisle 13
        {
            var Test = Math.Sqrt(Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2));
        }
    }
}


