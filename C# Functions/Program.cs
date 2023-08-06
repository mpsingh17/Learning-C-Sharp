using System.Text;

var keepGoing = true;

static (bool, int) IsPalindrome(string input)
{
    var isPalindrome = false;

    var stringBuilder = new StringBuilder();

    // Iterate over all chars of user input adn ignore the whitespaces and punctuations.
    foreach (var item in input)
    {
        if (!char.IsPunctuation(item) && !char.IsWhiteSpace(item))
            stringBuilder.Append(item);
    }

    var cleanedUserInput = stringBuilder.ToString();
    //Console.WriteLine($"Cleaned user input => {cleanedUserInput}");

    var reversedCleanUserInput = string.Concat(cleanedUserInput.Reverse());
    //Console.WriteLine($"Reversed user input => {reversedCleanUserInput}");

    if (cleanedUserInput.Equals(reversedCleanUserInput))
        isPalindrome = true;

    return (isPalindrome, input.Length);
}

do
{
    Console.WriteLine("Enter a text to see if it's a palindrome.");
    
    var userInput = Console.ReadLine();

    // If user entered exit, close the program.
    if (userInput == "exit")
    {
        keepGoing = false;
        Console.WriteLine("Thank you for your time. See you next time :)");

        continue;
    }

    if (userInput != null)
    {
        (bool isPalindrome, int length) = IsPalindrome(userInput.ToLower());

        if (isPalindrome)
            Console.WriteLine($"It's a palindrome with length = {length}");
        else
            Console.WriteLine($"Not a palindrome. Length of entered text is {length}");

    }
    else
        Console.WriteLine("Please enter a text value");

} while (keepGoing);


