namespace Galactica_silj4261
{
    internal class Planet : SpaceObjects
    {
        public double Diameter { get; set; } // In meters 
        public double RotationPeriod { get; set; } // In hours
        public double RevolutionPeriod { get; set; } // In days
        public PlanetType PlanetType { get; set; } // NOT MENTIONED IN TASK

        public List<Moon> Moons = new();

        public double Distance(Star star, Planet planet) // TODO Cleanup on aisle 13
        {
            double distance = Math.Sqrt(Math.Pow(star.Position_.X - star.Position_.Y, 2) + Math.Pow(planet.Position_.X - planet.Position_.Y, 2));
            return distance;
        }
    }
}


