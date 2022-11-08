using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class PlayerClass
    {
        public string name;
        public Roshambo roshambo;
        
        public virtual Roshambo GenerateRoshambo()
        {
            Array values = Enum.GetValues(typeof(Roshambo));
            Random random = new Random();
            Roshambo pickRandom = (Roshambo)values.GetValue(random.Next(values.Length));
            return pickRandom;
        }
    }
}
