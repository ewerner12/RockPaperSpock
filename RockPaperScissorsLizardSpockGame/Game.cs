using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// while naming:
//// don't use abbreviations!
//// don't add numbers to end of variable names but type them out if you must use them!
//// the program should NOT know the difference between classes (human vs. CPU)!

namespace RockPaperScissorsLizardSpockGame
{
    class Game
    {
        //// easier to get a number out of an enum
        //// used an array cause it's easier to print from (for the menu)
        private string[] GameMoves = { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
        //// consider not instantiating first human to allow for two CPUs to play against each other???
        private Player firstPlayer = new Human();
        private Player secondPlayer;
        private string gameType;

        public void BeginGame()
        {
            firstPlayer.SetName();
            SetGameType();
            SetGamePlayType();
        }

        public void SetGameType()
        {
            while((gameType != "1") && (gameType != "2"))
            {
                Console.WriteLine("\nHello {0}! Would you like to play against the [1]CPU or another [2]human?",
                                firstPlayer.GetName());
                gameType = Console.ReadLine();
            }
        }

        public void SetGamePlayType()
        {
            if (gameType == "1")
            {
                // versus CPU
                secondPlayer = new CPU();
                DisplayGoodLuckAgainstCPUMessage();
                PlayGame();
            }
            else
            {
                // versus another human
                secondPlayer = new Human();
                secondPlayer.SetName();
                DisplayGoodLuckHumansMessage();
                PlayGame();
            }
        }

        //// don't need to pass Player objects as arguments since they are already available to the class
        public void DisplayGoodLuckAgainstCPUMessage()
        {
            Console.WriteLine("\nGood luck against {0}!", secondPlayer.GetName());
        }

        public void DisplayGoodLuckHumansMessage()
        {
            Console.WriteLine("\nWelcome, {0} and {1}. Have fun!",
                                    firstPlayer.GetName(), secondPlayer.GetName());
        }

        public void PlayGame()
        {
            secondPlayer.MakeMove();
            firstPlayer.MakeMove();
            DisplayResults();
            CalculateWinner();
            AskToPlayAgain();
        }

        public void DisplayResults()
        {
            Console.WriteLine("\n>>>RESULTS<<<");
            Console.WriteLine("{0} chose: {1}.", firstPlayer.GetName(), GameMoves[firstPlayer.GetMove() - 1]);
            Console.WriteLine("{0} chose: {1}.", secondPlayer.GetName(), GameMoves[secondPlayer.GetMove() - 1]);
        }

        public void CalculateWinner()
        {
            int result = (5 + firstPlayer.GetMove() - secondPlayer.GetMove()) % 5;

            if((result == 1) || (result == 3))
            {
                // player 1 wins
                DeclareWinnerMessage(firstPlayer);
            }
            else if((result == 2) || (result == 4))
            {
                // player 2 wins
                DeclareWinnerMessage(secondPlayer);
            }
            else
            {
                // tie
                DeclareTieMessage();
            }
        }

        public void DeclareWinnerMessage(Player winner)
        {
            Console.WriteLine("\n{0} is the winner!!", winner.GetName());
        }

        public void DeclareTieMessage()
        {
            Console.WriteLine("\nIt's a tie!");
        }
         
        public void AskToPlayAgain()
        {
            int replayInput;

            Console.WriteLine("\nWould you like to play again? \n" +
                            "[1] YES or [2] NO?");
            bool response = int.TryParse(Console.ReadLine(), out replayInput);

            if(response == false)
            {
                AskToPlayAgain();
            }
            else
            {
                RestartGame(replayInput);
            }
        }

        public void RestartGame(int replayInput)
        {
            switch(replayInput)
            {
                case 1:
                    SetGamePlayType();
                    break;
                case 2:
                    EndGame();
                    break;
                default:
                    AskToPlayAgain();
                    break;
            }

            ////while ((playAgainNumb != 1) && (playAgainNumb != 2))
            ////{
            ////    AskToPlayAgain(player1, player2);
            ////}

            ////if (playAgainNumb == 1)
            ////{
            ////    StartGamePlay();
            ////}
            ////else
            ////{
            ////    EndGame(player1, player2);
            ////}
        }

        public void EndGame()
        {
            Console.WriteLine("\nThanks for playing, {0} and {1}!", firstPlayer.GetName(),
                secondPlayer.GetName());
            ExitGame();
        }

        public void ExitGame()
        {
            Console.WriteLine("\nGoodbye!\n");
        }
    }
}
