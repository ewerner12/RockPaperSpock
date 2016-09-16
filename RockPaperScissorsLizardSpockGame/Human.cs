using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockGame
{
    class Human : Player
    {

        public override void SetName()
        {
            Console.WriteLine("\nPlease enter your player name: ");
            name = Console.ReadLine();
        }

        public override void MakeMove()
        {
            int moveNumber;

            Console.WriteLine("\n{0}, please select from the numbers below to choose a move: ", this.GetName());

            foreach (string move in GameMoves)
            {
                Console.WriteLine("[" + ((Array.IndexOf(GameMoves, move)) + 1) + "] " + move);
            }

            bool response = int.TryParse(Console.ReadLine(), out moveNumber);

            if (response == false)
            {
                MakeMove();
            }
            else
            {
                playerMove = Convert.ToInt32(moveNumber);

                while ((playerMove < 1) || (playerMove > 5))
                {
                    MakeMove();
                }
            }
        }
    }
}
