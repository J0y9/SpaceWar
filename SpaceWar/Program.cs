
using SpaceWar;


    Alien.Recruit("Alien1", 10);
    Alien.Recruit("Alien2", 8);
    Alien.Recruit("Alien3", 12);

    Alien.Imprison("Alien2");
    SpaceShip.ListCrew();

    SpaceShip.Fight();
Alien.Release("Alien2");

SpaceShip.ListCrew();




//public static class SpaceshipManager
//{
//    private static List<Alien> crew = new ();

//    public static void RecruitAlien(string name, int strength)
//    {
//        crew.Add(new Alien(name, strength));
//        Console.WriteLine($"{name} has joined the crew.");
//    }

//    public static void ImprisonAlien(string name)
//    {
//        var alien = crew.FirstOrDefault(a => a.Name == name && !a.IsPrisoner);
//        if (alien != null)
//        {
//            alien.IsPrisoner = true;
//            Console.WriteLine($"{name} has been imprisoned.");
//        }
//        else
//        {
//            Console.WriteLine($"{name} is not part of the crew.");
//        }
//    }

//    public static void ReleaseAlien(string name)
//    {
//        var alien = crew.FirstOrDefault(a => a.Name == name && a.IsPrisoner);
//        if (alien != null)
//        {
//            alien.IsPrisoner = false;
//            Console.WriteLine($"{name} has been released from prison.");
//        }
//        else
//        {
//            Console.WriteLine($"{name} is not a prisoner.");
//        }
//    }

//    public static void ListCrew()
//    {
//        Console.WriteLine("Spaceship Crew:");
//        crew.ForEach(alien =>
//        {
//            string status = alien.IsPrisoner ? "Prisoner" : "Crew Member";
//            Console.WriteLine($"{alien.Name} ({status}, Strength: {alien.Strength})");
//        });
//    }

//    public static void Fight()
//    {
//        var activeCrew = crew.Where(a => !a.IsPrisoner).ToList();
//        if (activeCrew.Count < 2)
//        {
//            Console.WriteLine("Not enough crew members to start a fight.");
//            return;
//        }

//        var random = new Random();
//        int alienIndex1 = random.Next(activeCrew.Count);
//        int alienIndex2 = random.Next(activeCrew.Count);

//        var alien1 = activeCrew[alienIndex1];
//        var alien2 = activeCrew[alienIndex2];

//        Console.WriteLine($"{alien1.Name} fights {alien2.Name}!");

//        if (alien1.Strength > alien2.Strength)
//        {
//            Console.WriteLine($"{alien1.Name} wins!");
//            ReleaseAlien(alien2.Name);
//        }
//        else if (alien2.Strength > alien1.Strength)
//        {
//            Console.WriteLine($"{alien2.Name} wins!");
//            ReleaseAlien(alien1.Name);
//        }
//        else
//        {
//            Console.WriteLine("It's a draw!");
//        }
//    }

//    public static void Main()
//    {
//        RecruitAlien("Alien1", 10);
//        RecruitAlien("Alien2", 8);
//        RecruitAlien("Alien3", 12);

//        ImprisonAlien("Alien2");

//        ListCrew();

//        Fight();

//        ListCrew();
//    }
//}

