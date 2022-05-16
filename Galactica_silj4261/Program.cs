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
    Position_ = new SpaceObjects.Position() { X = 2, Y = 4 },
    PlanetType = PlanetType.Terrestial,
    Diameter = 4879400,
    RotationPeriod = 1407.5,
    RevolutionPeriod = 88
};
Planet Venus = new()
{
    Id = 3,
    Name = "Venus",
    Position_ = new SpaceObjects.Position() { X = 6, Y = 8 },
    PlanetType = PlanetType.Terrestial,
    Diameter = 12104000,
    RotationPeriod = 2802,
    RevolutionPeriod = 225
};
Planet Earth = new()
{
    Id = 4,
    Name = "Earth",
    Position_ = new SpaceObjects.Position() { X = 9, Y = 5 },
    PlanetType = PlanetType.Terrestial,
    Diameter = 12742000,
    RotationPeriod = 23.93,
    RevolutionPeriod = 365
};
Planet Mars = new()
{
    Id = 5,
    Name = "Mars",
    Position_ = new SpaceObjects.Position() { X = 3, Y = 16 },
    PlanetType = PlanetType.Terrestial,
    Diameter = 6779000,
    RotationPeriod = 24.62,
    RevolutionPeriod = 687
};
Planet Jupiter = new()
{
    Id = 6,
    Name = "Jupiter",
    Position_ = new SpaceObjects.Position() { X = 13, Y = 51 },
    PlanetType = PlanetType.Gas_Giant,
    Diameter = 13982000,
    RotationPeriod = 9.93,
    RevolutionPeriod = 4380
};
Planet Saturn = new()
{
    Id = 7,
    Name = "Saturn",
    Position_ = new SpaceObjects.Position() { X = 26, Y = 10 },
    PlanetType = PlanetType.Gas_Giant,
    Diameter = 116460000,
    RotationPeriod = 10.7,
    RevolutionPeriod = 10585
};
Planet Uranus = new()
{
    Id = 8,
    Name = "Uranus",
    Position_ = new SpaceObjects.Position() { X = 168, Y = 106 },
    PlanetType = PlanetType.Gas_Giant,
    Diameter = 50724000,
    RotationPeriod = 17.23,
    RevolutionPeriod = 30660
};
Planet Neptune = new()
{
    Id = 9,
    Name = "Neptune",
    Position_ = new SpaceObjects.Position() { X = 290, Y = 70 },
    PlanetType = PlanetType.Giant,
    Diameter = 49244000,
    RotationPeriod = 16.1,
    RevolutionPeriod = 60225
};


Moon Luna = new()
{
    Id = 10,
    Name = "Luna",
    Position_ = new SpaceObjects.Position() { X = 10, Y = 6 },
    Diameter = 3474800,
    RotationPeriod = 655.73,
    RevolutionPeriod = 27,
    Orbiting = Earth
};
Moon Deimos = new()
{
    Id = 11,
    Name = "Deimos",
    Position_ = new SpaceObjects.Position() { X = 3, Y = 17 },
    Diameter = 12400,
    RotationPeriod = 30.28,
    RevolutionPeriod = 1.26,
    Orbiting = Mars
};
Moon Phobos = new()
{
    Id = 12,
    Name = "Phobos",
    Position_ = new SpaceObjects.Position() { X = 5, Y = 18 },
    Diameter = 22533,
    RotationPeriod = 7.65,
    RevolutionPeriod = 0.32,
    Orbiting = Mars
};
Moon Europa = new() // Europa, not Europe
{
    Id = 13,
    Name = "Europa",
    Position_ = new SpaceObjects.Position() { X = 5, Y = 19 },
    Diameter = 3121600,
    RotationPeriod = 85.23,
    RevolutionPeriod = 3.5,
    Orbiting = Jupiter
};
Moon Ganymedes = new()
{
    Id = 14,
    Name = "Ganymedes",
    Position_ = new SpaceObjects.Position() { X = 14, Y = 51 },
    Diameter = 5268200,
    RotationPeriod = 172,
    RevolutionPeriod = 7.155,
    Orbiting = Jupiter
};
Moon Io = new()
{
    Id = 15,
    Name = "Io",
    Position_ = new SpaceObjects.Position() { X = 13, Y = 52 },
    Diameter = 3642000,
    RotationPeriod = 42.5,
    RevolutionPeriod = 1.8,
    Orbiting = Jupiter
};
Moon Titan = new()
{
    Id = 16,
    Name = "Titan",
    Position_ = new SpaceObjects.Position() { X = 27, Y = 9 },
    Diameter = 5149500,
    RotationPeriod = 382,
    RevolutionPeriod = 15.92,
    Orbiting = Saturn
};
Moon Mimas = new()
{
    Id = 17,
    Name = "Mimas",
    Position_ = new SpaceObjects.Position() { X = 26, Y = 9 },
    Diameter = 396400,
    RotationPeriod = 22.6,
    RevolutionPeriod = 0.94,
    Orbiting = Saturn
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

foreach (var planet in Sun.Planets)
{
    Console.WriteLine($"{planet.Name} ({planet.PlanetType}) - distance from Sun: {planet.Distance(Sun, planet)}");
    if (planet.Moons.Any())
    {
        foreach (var moon in planet.Moons)
        {
            Console.WriteLine($"{moon.Name} - distance from {planet.Name}: {(int)moon.Distance(planet, moon)}");
        }
    }
    Console.WriteLine();
}

//Console.SetWindowSize(Console.LargestWindowWidth - 10, Console.LargestWindowHeight - 10);
//Console.SetCursorPosition(Sun.position.X, Sun.position.Y);
//Console.Write(Sun.Name);

//foreach (Planet planet in Sun.Planets)
//{
//    if (planet.position.X < Console.WindowWidth && planet.position.Y < Console.WindowHeight)
//    {
//        Console.SetCursorPosition(planet.position.X, planet.position.Y);
//        Console.Write(planet.Name);
//    }
//    else
//    {
//        string test = $"{planet.Name} {planet.position.Y - Console.WindowWidth}";
//        Console.SetCursorPosition(Console.WindowWidth - test.Length, planet.position.Y);
//        Console.Write(test);
//    }
//    Console.WriteLine($"{planet.Name} ({planet.PlanetType}) - distance from Sun: {planet.Distance(Sun, planet)}");

//}

Console.ReadKey();