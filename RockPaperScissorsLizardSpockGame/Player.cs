using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpockGame
{
    class Player
    {
        protected string name;
        protected int playerMove;
        protected string[] GameMoves = { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };

        public Player()
        {
            
        }

        public string GetName()
        {
            return name;
        }

        public virtual void SetName()
        {

        }

        public int GetMove()
        {
            return playerMove;
        }

        public virtual void MakeMove()
        {

        }
    }
}
