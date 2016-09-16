using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Here are your rules: 
   "Scissors cuts paper, paper covers rock, 
   rock crushes lizard, lizard poisons Spock, 
   Spock smashes scissors, scissors decapitate lizard, 
   lizard eats paper, paper disproves Spock, 
   Spock vaporizes rock. 
   And as it always has, rock crushes scissors." 
   -- Dr. Sheldon Cooper */

namespace RockPaperScissorsLizardSpockGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.BeginGame();

            Console.ReadLine();
        }
    }
}
