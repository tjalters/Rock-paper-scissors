using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class AI : Player
    {

        public AI()
        {
            name = "AI";
        }
        public override void MakeWeaponChoice()

        {
            base.MakeWeaponChoice();
            Random random = new Random(choice);
            choice = random.Next(0, 5);
            Console.WriteLine($"Computer chose {choice}");
            
        }
    }
}
