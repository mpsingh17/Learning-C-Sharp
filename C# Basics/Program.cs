Console.WriteLine("Let's pay the guess number game.");
Console.WriteLine("I'm thinking of a number between 0 - 30.");
Console.WriteLine("Let's see how many guesses you'll take to guess the right number.");
Console.WriteLine("If you want to quit, type -1.");

// program selects a random number between 0 and 30.
var randomNumber = new Random().Next(30);

// variable to keep track of user's guesses.
var guessCounter = 0;

// flag variable to enable program to keep asking for the input from the user.
var success = false;

while (!success)
{
    var enteredValue = Console.ReadLine();

    success = Int32.TryParse(enteredValue, out var parsedEnteredValue);

    // if user input anything other than a natural number, show message and skip the iteration.
    if(!success)
    {
        Console.WriteLine("Please enter a natural number between 0 to 30");
        continue;
    }

    // User decided to quit. Show message and exit the loop.
    if (parsedEnteredValue == -1)
    {
        Console.WriteLine($"You did your best. Better luck next time. You made {guessCounter} guesses");
        break;
    }

    if (parsedEnteredValue < 0 | parsedEnteredValue > 30)
    {
        Console.WriteLine("Please enter a value between 0 and 30");
        success = false; // set success to false so loop can continue to run.
        continue;
    }

    // User made a guess so increment the guess counter.
    guessCounter++;

    // User won.
    if (parsedEnteredValue == randomNumber)
    {
        Console.WriteLine($"You Win! You took {guessCounter} guesses to win.");
        break;
    }
    // User input is greater than guessed number.
    else if (parsedEnteredValue > randomNumber)
    {
        Console.WriteLine("Your guess is greater.");

    }
    // user input is lower than guessed number.
    else
    {
        Console.WriteLine("Your guess is lower.");
    }

    // User didn't won so set success to false to keep the loop going.
    success = false;

}







