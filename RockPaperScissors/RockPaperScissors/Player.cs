using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player 
    {
        public HandSign currentHandSign;
        public int playerCurrentWins=0;
        public int playerCurrentLoss=0;
        public string name;
        public Player(string name, HandSign chosenHandSign,int playerWins,int playerLoss)
        {
            this.name = name;
            this.currentHandSign = chosenHandSign;
            this.playerCurrentWins = playerWins;
            this.playerCurrentLoss = playerLoss;
        }

        public string GetPlayerName()
        {
            Console.WriteLine("What is this players name?");
            string playerName = (Console.ReadLine());
            Console.WriteLine(playerName);
            return playerName;
        }

        //public HandSign GetPlayerHandSign()
        //{

        //}
    }
}
