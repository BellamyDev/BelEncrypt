public class encryptor{
    public string getString(){
        verboseMode.vPrint("Getting string to encrypt");//sends message to verboseMode

        string word;
        Console.WriteLine("Enter a string to encrypt: ");
        word=Console.ReadLine();
        verboseMode.vPrint("String to encrypt: " + word);//sends message to verboseMode
        return word;
        
    }
    public void encryptString(string word){
        verboseMode.vPrint("Starting string encryption");//sends message to verboseMode
        string newWord;
        char[] charArr= new char[word.Length];
        verboseMode.vPrint("Converting string to char array");//sends message to verboseMode
        charArr=word.ToLower().ToCharArray();


    }

}