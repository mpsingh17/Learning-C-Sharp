using System.Text;

var keepGoing = true;

static (bool, int) IsPalindrome(string input)
{
    var isPalindrome = false;
    var notAllowedChars = new string[] { " ", ",", "'", "?", "!" };

    var stringToReturn = new StringBuilder(input);

    foreach (var item in notAllowedChars)
    {
        stringToReturn.Replace(item, "");
    }

    var cleanedUserInput = stringToReturn.ToString();
    // Console.WriteLine($"Cleaned user input=> {cleanedUserInput}");

    var reversedCleanUserInput = string.Concat(cleanedUserInput.Reverse());
    // Console.WriteLine($"Reversed user input=> {reversedCleanUserInput}");

    if (cleanedUserInput.Equals(reversedCleanUserInput))
        isPalindrome = true;

    return (isPalindrome, isPalindrome ? cleanedUserInput.Length : 0);
}

do
{
    Console.WriteLine("Enter a text to see if it's a palindrome.");
    
    var userInput = Console.ReadLine();

    if (userInput != null)
    {
        (bool isPalindrome, int length) = IsPalindrome(userInput.ToLower());

        if (isPalindrome)
            Console.WriteLine($"It's a palindrome with length = {length}");
        else
            Console.WriteLine("Not a palindrome");

    }
    else
        Console.WriteLine("Please enter a text value");

    if (userInput == "exit")
        keepGoing = false;


} while (keepGoing);


