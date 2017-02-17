using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Player
    {
        public string name;
        int score;
        public string choice;
        public Player()
        {

        }
        public void GetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
        public virtual void MakeWeaponChoice()
        {
            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "Rock":
                    Console.WriteLine("selected " + choice);
                    break;
                case "Paper":
                    Console.WriteLine("selected" + choice);
                    break;
                case "Scissors":
                    Console.WriteLine("selected" + choice);
                    break;
                case "Lizard":
                    Console.WriteLine("selected" + choice);
                    break;
                case "Spock":
                    Console.WriteLine("selected" + choice);
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
        }
        
    }
}
