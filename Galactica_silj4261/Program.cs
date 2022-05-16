// Why is position just.. fucked up?
using Galactica_silj4261;

Star Sun = new()
{
    Id = 1,
    Name = "Sun",
    StarType = StarType.YellowDwarf,
    Temperature = 5778
};


Planet Mercury = new()
{
    Id = 2,
    Name = "Mercury",
    position = new SpaceObjects.Position() { X = Tools.RandomPosition(), Y = Tools.RandomPosition() },
    PlanetType = PlanetType.Terrestial,
    Diameter = 4879400,
    RotationPeriod = 1407.5,
    RevolutionPeriod = 88
};
Planet Venus = new()
{
    Id = 3,
    Name = "Venus",
    position = new SpaceObjects.Position() { X = Tools.RandomPosition(), Y = Tools.RandomPosition() },
    PlanetType = PlanetType.Terrestial,
    Diameter = 12104000,
    RotationPeriod = 2802,
    RevolutionPeriod = 225
};
Planet Earth = new()
{
    Id = 4,
    Name = "Earth",
    position = new SpaceObjects.Position() { X = Tools.RandomPosition(), Y = Tools.RandomPosition() },
    PlanetType = PlanetType.Terrestial,
    Diameter = 12742000,
    RotationPeriod = 23.93,
    RevolutionPeriod = 365
};
Planet Mars = new()
{
    Id = 5,
    Name = "Mars",
    position = new SpaceObjects.Position() { X = Tools.RandomPosition(), Y = Tools.RandomPosition() },
    PlanetType = PlanetType.Terrestial,
    Diameter = 6779000,
    RotationPeriod = 24.62,
    RevolutionPeriod = 687
};
Planet Jupiter = new()
{
    Id = 6,
    Name = "Jupiter",
    position = new SpaceObjects.Position() { X = Tools.RandomPosition(), Y = Tools.RandomPosition() },
    PlanetType = PlanetType.Gas_Giant,
    Diameter = 13982000,
    RotationPeriod = 9.93,
    RevolutionPeriod = 4380
};
Planet Saturn = new()
{
    Id = 7,
    Name = "Saturn",
    position = new SpaceObjects.Position() { X = Tools.RandomPosition(), Y = Tools.RandomPosition() },
    PlanetType = PlanetType.Gas_Giant,
    Diameter = 116460000,
    RotationPeriod = 10.7,
    RevolutionPeriod = 10585
};
Planet Uranus = new()
{
    Id = 8,
    Name = "Uranus",
    position = new SpaceObjects.Position() { X = Tools.RandomPosition(), Y = Tools.RandomPosition() },
    PlanetType = PlanetType.Gas_Giant,
    Diameter = 50724000,
    RotationPeriod = 17.23,
    RevolutionPeriod = 30660
};
Planet Neptune = new()
{
    Id = 9,
    Name = "Neptune",
    position = new SpaceObjects.Position() { X = Tools.RandomPosition(), Y = Tools.RandomPosition() },
    PlanetType = PlanetType.Giant,
    Diameter = 49244000,
    RotationPeriod = 16.1,
    RevolutionPeriod = 60225
};


Moon Luna = new()
{
    Id = 10,
    Name = "Luna",
    Diameter = 3474800,
    RotationPeriod = 655.73,
    RevolutionPeriod = 27,
    Orbiting = Earth,
    position = new SpaceObjects.Position() { X = Earth.position.X + 1, Y = Earth.position.Y + 1 }
};
Moon Deimos = new()
{
    Id = 11,
    Name = "Deimos",
    Diameter = 12400,
    RotationPeriod = 30.28,
    RevolutionPeriod = 1.26,
    Orbiting = Mars,
    position = new SpaceObjects.Position() { X = Mars.position.X + 1, Y = Mars.position.Y - 1 }
};
Moon Phobos = new()
{
    Id = 12,
    Name = "Phobos",
    Diameter = 22533,
    RotationPeriod = 7.65,
    RevolutionPeriod = 0.32,
    Orbiting = Mars,
    position = new SpaceObjects.Position() { X = Mars.position.X - 1, Y = Mars.position.Y + 1 }
};
Moon Europa = new() // Europa, not Europe
{
    Id = 13,
    Name = "Europa",

    Diameter = 3121600,
    RotationPeriod = 85.23,
    RevolutionPeriod = 3.5,
    Orbiting = Jupiter,
    position = new SpaceObjects.Position() { X = Jupiter.position.X + 1, Y = Jupiter.position.Y + 2 }
};
Moon Ganymedes = new()
{
    Id = 14,
    Name = "Ganymedes",
    Diameter = 5268200,
    RotationPeriod = 172,
    RevolutionPeriod = 7.155,
    Orbiting = Jupiter,
    position = new SpaceObjects.Position() { X = Jupiter.position.X + 3, Y = Jupiter.position.Y + 1 }
};
Moon Io = new()
{
    Id = 15,
    Name = "Io",
    Diameter = 3642000,
    RotationPeriod = 42.5,
    RevolutionPeriod = 1.8,
    Orbiting = Jupiter,
    position = new SpaceObjects.Position() { X = Jupiter.position.X + 1, Y = Jupiter.position.Y + 1 }
};
Moon Titan = new()
{
    Id = 16,
    Name = "Titan",
    Diameter = 5149500,
    RotationPeriod = 382,
    RevolutionPeriod = 15.92,
    Orbiting = Saturn,
    position = new SpaceObjects.Position() { X = Saturn.position.X + 1, Y = Saturn.position.Y + 2 }
};
Moon Mimas = new()
{
    Id = 17,
    Name = "Mimas",
    Diameter = 396400,
    RotationPeriod = 22.6,
    RevolutionPeriod = 0.94,
    Orbiting = Saturn,
    position = new SpaceObjects.Position() { X = Saturn.position.X + 3, Y = Saturn.position.Y + 2 }

};

Sun.Planets.Add(Mercury);
Sun.Planets.Add(Venus);
Sun.Planets.Add(Earth);
Sun.Planets.Add(Mars);
Sun.Planets.Add(Jupiter);
Sun.Planets.Add(Saturn);
Sun.Planets.Add(Uranus);
Sun.Planets.Add(Neptune);

Earth.Moons.Add(Luna);
Mars.Moons.Add(Deimos);
Mars.Moons.Add(Phobos);
Jupiter.Moons.Add(Europa);
Jupiter.Moons.Add(Ganymedes);
Jupiter.Moons.Add(Io);
Saturn.Moons.Add(Titan);
Saturn.Moons.Add(Mimas);

Tools.Print(Sun);

Console.ReadKey();