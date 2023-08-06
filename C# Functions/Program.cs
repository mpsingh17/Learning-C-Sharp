using System.Text;

var keepGoing = true;

static (bool, int) IsPalindrome(string input)
{
    var isPalindrome = false;
    var notAllowedChars = new string[] { " ", ",", "'", "?", "!" };

    var stringBuilder = new StringBuilder(input);

    foreach (var item in notAllowedChars)
        stringBuilder.Replace(item, "");

    var cleanedUserInput = stringBuilder.ToString();

    var reversedCleanUserInput = string.Concat(cleanedUserInput.Reverse());

    if (cleanedUserInput.Equals(reversedCleanUserInput))
        isPalindrome = true;

    return (isPalindrome, cleanedUserInput.Length);
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


