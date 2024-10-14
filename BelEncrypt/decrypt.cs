using System;

public class decrypt
{
    public static string getString()
    {
        verboseMode.vPrint("Getting string to decrypt");
        string word;
        Console.WriteLine("Enter a string to decrypt: ");
        word = Console.ReadLine();
        if (word.Length == 0)
        {
            verboseMode.vPrint("No string entered");
            Console.WriteLine("No string entered, exiting program");
            Environment.Exit(0);
        }
        verboseMode.vPrint("String to decrypt: " + word);
        return word;
    }

    // Decrypts a message, handling encrypted letters, numbers wrapped in '%', and unsupported characters
    public static string DecryptMessage(string encryptedMessage)
    {
        string decryptedMessage = "";
        int i = 0;

        verboseMode.vPrint("Decrypting message");

        while (i < encryptedMessage.Length)
        {
            if (encryptedMessage[i] == '%')
            {
                // Handle numbers wrapped in '%'
                int closingPercentIndex = encryptedMessage.IndexOf('%', i + 1);
                if (closingPercentIndex > i)
                {
                    // Extract the number between '%' including the '%' signs
                    string number = encryptedMessage.Substring(i, closingPercentIndex - i + 1); // Include '%' characters
                    string decryptedChar = letterEncrypt.DecryptLetter(number);

                    decryptedMessage += decryptedChar;

                    i = closingPercentIndex + 1; // Move index after the closing '%'
                }
                else
                {
                    verboseMode.vPrint("Invalid encrypted format: Unmatched '%' detected.");
                    throw new ArgumentOutOfRangeException("The encrypted message contains an unmatched '%'.");
                }
            }
            else
            {
                // Try to get the next 5 characters for known encrypted letters
                if (i + 5 <= encryptedMessage.Length)
                {
                    string encryptedLetter = encryptedMessage.Substring(i, 5);
                    string decryptedChar = letterEncrypt.DecryptLetter(encryptedLetter);

                    if (decryptedChar == encryptedLetter)
                    {
                        
                        decryptedMessage += encryptedMessage[i];
                        i++;
                    }
                    else
                    {
                        decryptedMessage += decryptedChar;
                        i += 5;
                    }
                }
                else
                {
                    // Not enough characters left for a 5-character encrypted letter
 
                    decryptedMessage += encryptedMessage[i];
                    i++;
                }
            }
        }

        return decryptedMessage;
    }
}
