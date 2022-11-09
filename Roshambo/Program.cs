using RoshamboLab;

Console.WriteLine("What is your name?");
Player human = new HumanPlayer(Console.ReadLine());
Player opponent = Validators.GetOpponent();
string humanChoice = human.GenerateRoshambo().ToString();
string opponentChoice = opponent.GenerateRoshambo().ToString();
Console.WriteLine($"Your choice is: {humanChoice}");    
Console.WriteLine($"Your opponents choice is: {opponentChoice}");
string getWinner = Validators.GetWinner(humanChoice, opponentChoice);
Console.WriteLine(getWinner);