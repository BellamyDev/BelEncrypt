public class decrypt{
     public static string DecryptMessage(string encryptedMessage)
    {
        string decryptedMessage = "";

        // Iterate through the encrypted string in chunks of 5 (as each encrypted letter is 5 characters long)
        verboseMode.vPrint("Decrypting message");//sends message to verboseMode
        for (int i = 0; i < encryptedMessage.Length; i += 5)
        {
            string encryptedLetter = encryptedMessage.Substring(i, 5); // Extract 5 characters
            decryptedMessage += letterEncrypt.DecryptLetter(encryptedLetter); // Decrypt each 5-char string
        }

        return decryptedMessage;
    }
}