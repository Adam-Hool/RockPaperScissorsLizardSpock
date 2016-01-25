using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class CompairHandSignChoises 
    {
        public CompairHandSignChoises()
        {

        }
        public string[] tie = { "its a tie" };
        public string[] p1Wins = { "player 1 wins" };
        public string[] p2Wins = { "player 2 wins" };
        public void CompairHandSigns(HandSign player1HandSign, HandSign player2HandSign)
        {
            if (player1HandSign is Rock && player2HandSign is Rock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", tie);
                Console.WriteLine("its a tie");
            }
            else if (player1HandSign is Rock && player2HandSign is Paper)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Rock && player2HandSign is Scissors)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Rock && player2HandSign is Spock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Rock && player2HandSign is Lizard)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Paper && player2HandSign is Paper)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", tie);
                Console.WriteLine("Its a tie");
            }
            else if (player1HandSign is Paper && player2HandSign is Rock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Paper && player2HandSign is Scissors)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Paper && player2HandSign is Spock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Paper && player2HandSign is Lizard)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Scissors && player2HandSign is Scissors)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", tie);
                Console.WriteLine("Its a tie");
            }
            else if (player1HandSign is Scissors && player2HandSign is Rock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Scissors && player2HandSign is Paper)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Scissors && player2HandSign is Spock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Scissors && player2HandSign is Lizard)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Lizard && player2HandSign is Lizard)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", tie);
                Console.WriteLine("its a tie");
            }
            else if (player1HandSign is Lizard && player2HandSign is Rock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Lizard && player2HandSign is Paper)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Lizard && player2HandSign is Scissors)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Lizard && player2HandSign is Spock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Spock && player2HandSign is Spock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", tie);
                Console.WriteLine("Its a tie");
            }
            else if (player1HandSign is Spock && player2HandSign is Rock)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");
            }
            else if (player1HandSign is Spock && player2HandSign is Paper)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
            else if (player1HandSign is Spock && player2HandSign is Scissors)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p1Wins);
                Console.WriteLine("player1 wins");

            }
            else if (player1HandSign is Spock && player2HandSign is Lizard)
            {
                System.IO.File.WriteAllLines(@"C:\devcodecamp\devCodeCampProjects\RockPaperScissors\RockPaperScissors\RPSLS.tst", p2Wins);
                Console.WriteLine("player2 wins");
            }
        }
    }
}
