public class encryptor{
    public string getString(){
        verboseMode.vPrint("Getting string to encrypt");//sends message to verboseMode

        string word;
        Console.WriteLine("Enter a string to encrypt: ");
        word=Console.ReadLine();
        if(word.Length==0){
            verboseMode.vPrint("No string entered");//sends message to verboseMode
            Console.WriteLine("No string entered, exiting program");
            Environment.Exit(0);
        }
        verboseMode.vPrint("String to encrypt: " + word);//sends message to verboseMode
        return word;
        
    }
    public void encryptString(string word){
        verboseMode.vPrint("Starting string encryption");//sends message to verboseMode
        char[] charArr= new char[word.Length];
        verboseMode.vPrint("Converting string to char array");//sends message to verboseMode
        charArr=word.ToLower().ToCharArray();
        string temp = "";
        string encryptedWord = "";
        verboseMode.vPrint("Encrypting string");//sends message to verboseMode
        for(int i=0;i<word.Length;i++){//encrypts each letter in the word
            temp = letterEncrypt.encryptLetter(charArr[i]);
            encryptedWord = encryptedWord + temp;//addes encrypted letters to the overallword
        }


    }

}