using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class ValidatorClass
    {
        public static int GetUserAnswer()
        {
            bool validChoice = false;
            do
            {
                try
                {
                    int answer = Convert.ToInt32(Console.ReadLine());
                    validChoice = true;
                    return answer;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("That is not a valid opponent. Please choose again");
                    validChoice = false;
                    return -1;
                };
            } while (!validChoice);
        }

        public static Rock GetPlayer()
        {
            int answer = GetUserAnswer();
            if (answer == 1)
            {
                var player = RockPlayer rock = new RockPlayer();
                return player;
            }
        }
    }
}
