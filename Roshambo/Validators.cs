using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class Validators
    {
        public static int GetValidNumber(int maxRange, string message)
        {
            bool validChoice = false;
            do
            {
                Console.WriteLine(message);
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
                        validChoice = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid number. Please try again.");
                    validChoice = false;
                }
            } while (!validChoice);

            return -1;
        }

        public static Player GetOpponent()
        {
            string message = "Choose your opponent!\n1.Rock Player\n2.Random Player";
            int answer = GetValidNumber(2, message);
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

        public static bool PlayAgain(string answer)
        {
            bool repeat = false;
            do
            {
                if (answer == "y" || answer == "yes")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    return false;
                }
            } while (repeat);
        }

        public static string GetWinner(Player playerOne, Player playerTwo)
        {
            Roshambo player1Choice = playerOne.GenerateRoshambo();
            Roshambo player2Choice = playerTwo.GenerateRoshambo();

            string player1Return = $"Your choice is: {player1Choice}";
            string player2Return = $"\nOpponents choice is: {player2Choice}";

            if (player1Choice == player2Choice)
            {
                return $"{player1Return} {player2Return} \nTie Game!";
            }
            if (player1Choice == Roshambo.Scissors && player2Choice == Roshambo.Paper)
            {
                return $"{player1Return} {player2Return} \nScissors cuts paper! {playerOne.name} wins!";
            }
            if (player1Choice == Roshambo.Paper && player2Choice == Roshambo.Scissors)
            {
                return $"{player1Return} {player2Return} \nScissors cuts paper! {playerTwo.name} wins!";
            }
            if (player1Choice == Roshambo.Rock && player2Choice == Roshambo.Scissors)
            {
                return $"{player1Return} {player2Return} \nRock crushes scissors! {playerOne.name} wins!";
            }
            if (player1Choice == Roshambo.Scissors && player2Choice == Roshambo.Rock)
            {
                return $"{player1Return} {player2Return} \nRock crushes scissors! {playerTwo.name} wins!";
            }
            if (player1Choice == Roshambo.Paper && player2Choice == Roshambo.Rock)
            {
                return $"{player1Return} {player2Return} \nPaper covers rock! {playerOne.name} wins!";
            }
            else
            {
                return $"{player1Return} {player2Return} \nPaper covers rock! {playerTwo.name} wins!";
            }
        }
    }
}
