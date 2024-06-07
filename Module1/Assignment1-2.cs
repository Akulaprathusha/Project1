using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Assignment1_2
    {
        public void Game()
        {
            int HealthPoints = 100;
            String PlayerName;
            bool Hassword = false;
            Console.WriteLine("Enter Player Name");
            PlayerName = Console.ReadLine();
            Console.WriteLine($" Welcome to the play {PlayerName}");
            Console.WriteLine("You find a sword on the ground. Do you pick it up? (yes/no)");
            String input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                Console.WriteLine($"You picked up the sword. Your chance of survival has increased!");
                Hassword = true;
            }
            else
            {
                Console.WriteLine("You left the sword on the ground.");
            }
            Console.WriteLine("A wild monster appears! Do you fight or run? (fight/run)");
            input = Console.ReadLine();
            if (input.ToLower() == "fight")
            {
                if (Hassword)
                {
                    Console.WriteLine("Chances of survival is increased, you can kill monster using sword");
                }
                else
                {
                    Console.WriteLine("Injured!!!");
                    HealthPoints -= 50;
                }
            }
            else if (input.ToLower() == "run")
            {
                Console.WriteLine("You ran away safely.");
            }
            else
            {
                Console.WriteLine("Invalid choice. The monster attacks you while you hesitate.");
                HealthPoints -= 50;
                Console.WriteLine("Your health is now " + HealthPoints);
            }
            if (HealthPoints > 0)
            {
                Console.WriteLine("Congratulations! You survived the adventure.");
            }
            else
            {
                Console.WriteLine("You succumbed to your injuries. Game over.");
            }

        }
        
    }
}
