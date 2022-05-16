namespace Galactica_silj4261
{
    internal class Planet : SpaceObjects
    {
        public double Diameter { get; set; } // In meters 
        public double RotationPeriod { get; set; } // In hours
        public double RevolutionPeriod { get; set; } // In days

        List<Moon> Moon = new();

        double Distance(Star star, Planet planet) // TODO Cleanup on aisle 13
        {
            double distance = Math.Sqrt(Math.Pow(star.position.X - star.position.Y, 2) + Math.Pow(planet.position.X - planet.position.Y, 2));
            return distance;
        }
    }
}


