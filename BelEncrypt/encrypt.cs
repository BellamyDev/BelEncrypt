public class encrypt
{
    public string getString()
    {
        verboseMode.vPrint("Getting string to encrypt"); //sends message to verboseMode

        string word;
        Console.WriteLine("Enter a string to encrypt: ");
        word = Console.ReadLine();
        if (word.Length == 0)
        {
            verboseMode.vPrint("No string entered"); 
            Console.WriteLine("No string entered, exiting program");
            Environment.Exit(0);
        }
        verboseMode.vPrint("String to encrypt: " + word); 
        return word;
    }

    public string encryptString(string word)
    {
        verboseMode.vPrint("Starting string encryption");
        char[] charArr = new char[word.Length];
        verboseMode.vPrint("Converting string to char array"); 
        charArr = word.ToLower().ToCharArray();

        string temp = "";
        string encryptedWord = "";
        verboseMode.vPrint("Encrypting string"); 

        for (int i = 0; i < word.Length; i++)
        {
            // Use letterEncrypt to handle both letters and numbers
            temp = letterEncrypt.encryptLetter(charArr[i]);
            encryptedWord = encryptedWord + temp; 
        }

        verboseMode.vPrint("Encrypted message: " + encryptedWord); 
        return encryptedWord; 
    }
}
