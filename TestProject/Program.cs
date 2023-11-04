string inputPhrase = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] inputPhraseCharacters = inputPhrase.ToCharArray();

// Reverse the chars
Array.Reverse(inputPhraseCharacters);

int countOfCharacterO = 0;

// count the o's
foreach (char character in inputPhraseCharacters)
    {
        if (character == 'o')
        {
            countOfCharacterO++;
        }
    }

// convert it back to a string
string inputPhraseReversed = new String(inputPhraseCharacters);

// print it out
Console.WriteLine(inputPhraseReversed);
Console.WriteLine($"'o' appears {countOfCharacterO} times.");