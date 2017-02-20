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
        public int score;
        public int choice;
        public string weaponChoice;
        public int computerSelection;
        public Player()
        {

        }

        public virtual void MakeWeaponChoice()
        {
            
        }

        
        public void GetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
        
        
        
        
            
        

    }
}
