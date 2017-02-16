using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Game
    {
            Player PlayerOne;
            Player PlayerTwo;
        public Game()
        {
            
            PlayerOne = new Player();
            PlayerTwo = new Player();  
        }

        public void DisplayPrompt()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Spock Lizard");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            Console.WriteLine("Enter 1 to play against another user, enter 2 to play against computer");
            Console.ReadLine();
            //Create a method to give the user the option to pick whether they want to play against player 2 or AI
            Console.WriteLine("Pick either Rock, Paper, Scissors, Spock, or Lizard");
        }

        public void DisplayOutcomes(string rock, string paper, string scissors, string spock, string lizard)
        {
            Console.WriteLine(PlayerOne.options.rock);
            Console.WriteLine(PlayerTwo.options.spock);
        }

            
            
        }
}
