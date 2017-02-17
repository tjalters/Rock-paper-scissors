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


        }
        public void RunGame()
        {
            DisplayWelcome();
            GetNumberPlayers();
            PlayerOne.MakeWeaponChoice();
            PlayerTwo.MakeWeaponChoice();
            PlayRound();


        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Spock Lizard");
        }
        public void GetNumberPlayers()
        {
            Console.WriteLine("Enter '1' to play against computer, enter '2' to play against user");
            int HumanPlayers = int.Parse(Console.ReadLine());
            if (HumanPlayers == 1)
            {
                PlayerOne = new Human();
                PlayerTwo = new AI();
                PlayerOne.GetName();
                //This is where they select to play against another user
                //Player 1 is always a person, Player 2 is a person or computer
            }
            else if (HumanPlayers == 2)
            {
                PlayerOne = new Human();
                PlayerTwo = new Human();
                PlayerOne.GetName();
                PlayerTwo.GetName();
            }
            else
            {
                Console.WriteLine("Invalid entry");
                GetNumberPlayers();
            }
        }

        public void PlayRound() //based on the algorithm provided to us
        {
            int result = (5 + (PlayerOne.choice - PlayerTwo.choice)) % 5;
            if (result = 1 || result = 3 >= PlayerOne.choice)
                {//announce winner and add point to winner
                    Console.WriteLine("Player 1 wins!");
                    //if a = 1 or 3, player one wins 
                }
                else if (result = 2 || result = 4 >= PlayerTwo.choice)
                {
                    Console.WriteLine("Player 2 wins!");

                    //if b = 2 or 4, player two wins
                }
                else if(result == 0)
            {
                Console.WriteLine("Players tied. Play round again");
              
            }
        }

        public void CheckWinner()
        {
            if (PlayerOne.score == 2)
            {
                Console.WriteLine("Player 1 wins the game!");
            }
            else if (PlayerTwo.score == 2)
            {
                Console.WriteLine("Player 2 wins the game");
            }
        }
        public void DisplayOutcomes(string rock, string paper, string scissors, string spock, string lizard)
        {
            
        }

            
            
        }
}
