using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RoshamboLab
{
    public class HumanPlayer : PlayerClass
    {
        public string Name;

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
