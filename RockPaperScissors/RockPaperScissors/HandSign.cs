using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class HandSign : IHandSign
    {
        public string chosenSign;
        public HandSign(string chosenSign)
        {
            this.chosenSign = chosenSign;
        }

        public HandSign GetUserInputHandSign()
        {

            string ChosenHandSign = null;
            Console.WriteLine("What hand sign do you want to choose Rock, Paper, Scissors, Lizard, or Spock?");
            ChosenHandSign = Console.ReadLine();
            switch (ChosenHandSign)
            {
                case "Rock":
                    Rock rock = new Rock("Rock");
                    return rock;
                case "Paper":
                    Paper paper = new Paper("Paper");
                    return paper;
                case "Scissors":
                    Scissors scissors = new Scissors("Scissors");
                    return scissors;
                case "Lizard":
                    Lizard lizard = new Lizard("Lizard");
                    return lizard;
                case "Spock":
                    Spock spock = new Spock("Spock");
                    return spock;
                default:
                    return GetUserInputHandSign();
            }
        }

        public HandSign GetAIHandSign(int AIHandSign)
        {

            int ChosenHandSign =AIHandSign;
            switch (ChosenHandSign)
            {
                case 0:
                    Rock rock = new Rock("Rock");
                    return rock;
                case 1:
                    Paper paper = new Paper("Paper");
                    return paper;
                case 2:
                    Scissors scissors = new Scissors("Scissors");
                    return scissors;
                case 3:
                    Lizard lizard = new Lizard("Lizard");
                    return lizard;
                case 4:
                    Spock spock = new Spock("Spock");
                    return spock;
                default:
                    return GetUserInputHandSign();
            }
        }

    }
}
