using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWar
{
    public class SpaceShip
    {
        public static List<Alien> Crew = new ();
        public static void ListCrew()
        {
            Console.WriteLine("Spaceship Crew:");
            Crew.ForEach(alien =>
            {
                string status = alien.IsPrisoner ? "Prisoner" : "Crew Member";
                Console.WriteLine($"{alien.Name} ({status}, Strength: {alien.Strength})");
            });
        }
        public static void Fight()
        {
            var activeCrew = Crew.Where(a => !a.IsPrisoner).ToList();
            if (activeCrew.Count < 2)
            {
                Console.WriteLine("Not enough crew members to start a fight.");
                return;
            }

            var random = new Random();
            // [^] this code gives duplicated index
            //int alienIndex1 = random.Next(0,activeCrew.Count);
            //int alienIndex2 = random.Next(0,activeCrew.Count);
            //var alien1 = activeCrew[alienIndex1];
            //var alien2 = activeCrew[alienIndex2];
            int alienIndex1;
            int alienIndex2;

            do
            {
                alienIndex1 = random.Next(activeCrew.Count);
                alienIndex2 = random.Next(activeCrew.Count);
            } while (alienIndex1 == alienIndex2);

            var alien1 = activeCrew[alienIndex1];
            var alien2 = activeCrew[alienIndex2];


            Console.WriteLine($"{alien1.Name} fights {alien2.Name}!");

            if (alien1.Strength > alien2.Strength)
            {
                Console.WriteLine($"{alien1.Name} wins!");
                //Alien.Release(alien2.Name);
            }
            else if (alien2.Strength > alien1.Strength)
            {
                Console.WriteLine($"{alien2.Name} wins!");
                //Alien.Release(alien1.Name);
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
