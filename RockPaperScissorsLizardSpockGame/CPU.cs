using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockGame
{
    class CPU : Player
    {
        //// every CPU that is created is named 'HAL 9000'
        public CPU()
        {
            name = "HAL 9000";
        }

        public override void MakeMove()
        {
            Random rand = new Random();
            playerMove = (rand.Next(1, 6));
        }
    }
}
