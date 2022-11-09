using RoshamboLab;

Console.WriteLine("What is your name?");
Player human = new HumanPlayer(Console.ReadLine());
Player opponent = Validators.GetOpponent();
bool playAgain;
int tie = 0;
int wins = 0;
int losses = 0;

do
{
    string winnerText = Validators.GetWinner(human, opponent);
    if (winnerText.Contains("Tie"))
    {
        tie += 1;
    }
    else if (winnerText.Contains(human.name))
    {
        wins += 1;
    }
    else
    {
        losses += 1;
    }
    Console.WriteLine(winnerText);
    Console.WriteLine("Would you like to play again? y/n");
    playAgain = Validators.PlayAgain(Console.ReadLine());
}
while (playAgain);

Console.WriteLine($"Final Score:\n{human.name}:{wins}\n{opponent.name}:{losses}\nTie Games:{tie}");
