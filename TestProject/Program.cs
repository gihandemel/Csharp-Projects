Console.WriteLine("Please enter an integer value between 5 and 10:");
string? userInput;
int numericValue = 0;
bool validInput = false;


do {
    userInput = Console.ReadLine();
    validInput = int.TryParse(userInput, out numericValue);

        if ((validInput == true) && (numericValue > 5) && (numericValue < 10))
        {
            Console.WriteLine($"Your input value({userInput}) has been accepted.");
        }

        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
            validInput = false;
        }

} while (validInput == false);

