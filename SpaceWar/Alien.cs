namespace SpaceWar;
public class Alien
{
    public string Name;
    public int Strength;
    public bool IsPrisoner { get; set; }

    public Alien(string name, int strength)
    {
        Name = name;
        Strength = strength;
    }
    public static void Recruit(string name, int strength)
    {
        SpaceShip.Crew.Add(new Alien(name, strength));
        Console.WriteLine($"{name} has joined the crew.");
    }
    public static void Imprison(string name)
    {
        var alien = SpaceShip.Crew.FirstOrDefault(a => a.Name == name && !a.IsPrisoner);
        if (alien != null)
        {
            alien.IsPrisoner = true;
            Console.WriteLine($"{name} has been imprisoned.");
        }
        else
        {
            Console.WriteLine($"{name} is not part of the crew.");
        }
    }
    public static void Release(string name)
    {
        var alien = SpaceShip.Crew.FirstOrDefault(a => a.Name == name && a.IsPrisoner);
        if (alien != null)
        {
            alien.IsPrisoner = false;
            Console.WriteLine($"{name} has been released from prison.");
        }
        else
        {
            Console.WriteLine($"{name} is not a prisoner.");
        }
    }
}