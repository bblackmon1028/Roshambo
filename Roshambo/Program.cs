using RoshamboLab;

Console.WriteLine("What is your name?");
HumanPlayer human = new HumanPlayer(Console.ReadLine());

Console.WriteLine("Choose your opponent!");
Console.WriteLine("1. Rock Player");
Console.WriteLine("2. Random Player");
GetOpponent();