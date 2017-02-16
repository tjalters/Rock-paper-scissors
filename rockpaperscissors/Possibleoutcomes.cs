using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class GameRules
    {
            string rock;
            string paper;
            string scissors;
            string spock;
            string lizards;
            string playerOne;
            string playerTwo;
            string playerAi;
            player1 PlayerOne;
            player2 PlayerTwo;
            playerAI PlayerAi;
        public GameRules()
        {
            rock = "rock";
            paper = "paper";
            scissors = "scissors";
            spock = "spock";
            lizards = "lizard";
            playerOne = "playerOne";
            playerTwo = "playerTwo";
            playerAi = "playerAi";
            PlayerOne = new player1();
            PlayerTwo = new player2();
            PlayerAi = new playerAI();  
        }

        public DisplayPrompt()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Spock Lizard");
            Console.WriteLine("Do you want to play against another user? (yes or no)");
            //Create a method to give the user the option to pick whether they want to play against a player 2 or AI




            Console.WriteLine("Pick either Rock, Paper, Scissors, Spock, Lizard");
        }


            
        }
}
