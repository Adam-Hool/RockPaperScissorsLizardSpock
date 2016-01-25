using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class GetHandSign 
    {
        public GetHandSign(string chosenSign)
        {

        }

        public HandSign GetUserInputHandSign()
        {
            Console.WriteLine("What hand sign do you want to choose?");
            HandSign GetHandSign = new HandSign(Console.ReadLine());
            Console.WriteLine(GetHandSign);
            return GetHandSign;
        }
    }
}
