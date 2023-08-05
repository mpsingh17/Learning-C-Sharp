// Game start greeting messages.
Console.WriteLine("Let's pay the guess number game.");
Console.WriteLine("I'm thinking of a number between 0 - 30.");
Console.WriteLine("Let's see how many guesses you'll take to guess the right number.");
Console.WriteLine("If you want to quit, type -1.");

// program selects a random number between 0 and 30.
var randomNumber = new Random().Next(30);

// variable to keep track of user's guesses.
var guessCounter = 0;

// flag variable to enable program to keep asking for the input from the user.
var keepGoing = true;

while (keepGoing)
{
    var enteredValue = Console.ReadLine();

    keepGoing = Int32.TryParse(enteredValue, out var parsedEnteredValue);

    // if user input anything other than a natural number, show message and skip the iteration.
    if(!keepGoing)
    {
        Console.WriteLine("Please enter a natural number between 0 and 30");
        keepGoing = true;
        continue;
    }

    // User decided to quit. Show message and exit the loop.
    if (parsedEnteredValue == -1)
    {
        Console.WriteLine($"You did your best. Better luck next time. You made {guessCounter} guesses");
        break;
    }
    
    // User made a guess so increment the guess counter.
    guessCounter++;

    // If the parsedEnterValue is not between the 0 and 30.
    if (parsedEnteredValue < 0 | parsedEnteredValue > 30)
    {
        Console.WriteLine("Please enter a value between 0 and 30");
        keepGoing = true;
        continue;
    }
    
    // User won.
    if (parsedEnteredValue == randomNumber)
    {
        Console.WriteLine($"You Win! You took {guessCounter} guesses to win.");
        break;
    }

    Console.WriteLine(
        "You guessed {0} than random number.",
        parsedEnteredValue > randomNumber ? "greater" : "lower"
    );

    keepGoing = true;
}







