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
        public override MakeWeaponChoice()
        {
            
            Random random = new Random();
            int ComputerSelection = random.Next(0, 5);
            return ComputerSelection;
        }
    }
}
