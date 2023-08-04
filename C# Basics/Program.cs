Console.WriteLine("Let's pay the guess number game.");
Console.WriteLine("I'm thinking of a number between 0 - 30.");
Console.WriteLine("Let's see how many guesses you'll take to guess the right number.");
Console.WriteLine("If you want to quit, type -1.");


var randomNumber = new Random().Next(30);
var guessCounter = 0;
var success = false;

while (!success)
{
    var enteredValue = Console.ReadLine();

    success = Int32.TryParse(enteredValue, out var value);

    if(!success)
    {
        Console.WriteLine("Please enter a natural number between 0 to 30");
        continue;
    }

    guessCounter++;

    if (value == -1)
        break;

    if (value == randomNumber)
    {
        Console.WriteLine($"You Win! You took {guessCounter} guesses to win.");
        break;
    }
    else if (value > randomNumber)
    {
        Console.WriteLine("Your guess is greater.");

    }
    else
    {
        Console.WriteLine("Your guess is lower.");
    }
    success = false;

}







