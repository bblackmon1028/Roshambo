using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RoshamboLab
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string playerName)
        {
            name = playerName;
        }

        public override Roshambo GenerateRoshambo()
        {
            string message = "Select your choice!\n1. Rock, 2. Paper, 3. Scissors";
            int answer = Validators.GetValidNumber(3, message);
            if (answer == 1)
            {
                return Roshambo.Rock;
            }
            else if (answer == 2)
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissors;
            }
        }
    }
}
