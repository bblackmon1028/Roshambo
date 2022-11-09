using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class Validators
    {
        public static int GetValidNumber(int maxRange)
        {
            bool validChoice;
            do
            {
                try
                {
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer > 0 && answer <= maxRange)
                    {
                        validChoice = true;
                        return answer;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number. Please try again.");
                        return -1;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid number. Please try again.");
                    return -1;
                };
            } while (!validChoice);
        }

        public static Player GetOpponent()
        {
            Console.WriteLine("Choose your opponent!");
            Console.WriteLine("1. Rock Player");
            Console.WriteLine("2. Random Player");
            int answer = GetValidNumber(2);
            if (answer == 1)
            {
                var player = new RockPlayer();
                return player;
            }
            else
            {
                var player = new RandomPlayer();
                return player;
            }
        }
        
        public static string GetWinner(Player playerOne, Player playerTwo)
        {

            if (playerOne.GenerateRoshambo == playerTwo.GenerateRoshambo)
            {
                return "Tie Game!";
            }
            if (answerOne == Roshambo.Paper.ToString() && answerTwo == Roshambo.Scissors.ToString())
            {
                return "Scissors beats paper! ";
            }
            if (answerOne == Roshambo.Paper.ToString() && answerTwo == Roshambo.Rock.ToString() ||
                answerTwo == Roshambo.Rock.ToString() && answerOne == Roshambo.Paper.ToString())
            {
                return "Paper covers rock!";
            }
            else
            {
                return "Rock crushes scissors!";
            }
        }
    }
}
