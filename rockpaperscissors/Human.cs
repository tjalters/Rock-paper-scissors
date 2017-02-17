using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Human : Player
    {
        
        public Human()
        {
            
        }



        public virtual MakeWeaponChoice()
        {
            Console.WriteLine("Please choose 0 for Rock, 1 for Paper, 2 for Scissors, 3 for Lizard, or 4 for Spock");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("selected rock");
                    weaponChoice = "Rock";
                    break;
                case 1:
                    Console.WriteLine("selected paper");
                    weaponChoice = "Paper";
                    break;
                case 2:
                    Console.WriteLine("selected scissors");
                    weaponChoice = "Scissors";
                    break;
                case 3:
                    Console.WriteLine("selected lizard");
                    weaponChoice = "Lizard";
                    break;
                case 4:
                    Console.WriteLine("selected spock");
                    weaponChoice = "Spock";
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
        }




    }
}
