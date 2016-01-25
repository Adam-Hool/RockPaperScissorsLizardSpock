using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int player1Wins=0;
            int player2Wins=0;
            int player1Loss=0;
            int player2Loss=0;
            string player1Name;
            string player2Name;
            string AI = "AI";
            string human = "human";

            Console.WriteLine("playign against AI or human?");
            String chosenOponent = (Console.ReadLine());

            if (chosenOponent=="Human")
            {

                GetHandSign newHandSign = new GetHandSign(null);
                HandSign handSign = new HandSign(null);
                CompairHandSignChoises chosensigns = new CompairHandSignChoises();
                Player player1 = new Player("Adam", handSign.GetUserInputHandSign(), player1Wins, player1Loss);
                Player player2 = new Player("fred", handSign.GetUserInputHandSign(), player2Wins, player2Loss);
                Console.WriteLine("player1 chose " + player1.currentHandSign.chosenSign);
                Console.WriteLine("player2 chose {0}", player2.currentHandSign.chosenSign);
                chosensigns.CompairHandSigns(player1.currentHandSign, player2.currentHandSign);
            }
            else if (chosenOponent=="AI")
            {
                Random RandomNumber = new Random();
                int AIHandSign = RandomNumber.Next(5);
                GetHandSign newHandSign = new GetHandSign(null);
                HandSign handSign = new HandSign(null);
                CompairHandSignChoises chosensigns = new CompairHandSignChoises();
                Player player1 = new Player("Adam", handSign.GetUserInputHandSign(), player1Wins, player1Loss);
                Player player2 = new Player("fred", handSign.GetAIHandSign(AIHandSign), player2Wins, player2Loss);
                Console.WriteLine("player1 chose "+ player1.currentHandSign.chosenSign);
                Console.WriteLine("player2 chose {0}",player2.currentHandSign.chosenSign);
            }

           
            




        }
    }
}
