
using System.Security.Cryptography.X509Certificates;

class Program
    {
        static void Main(string[] args)
        {
            int option;
            
            
            bool repeat = true;
            while (repeat == true){
                option = startMenu.start();//returns 1 if encrypt, 2 if decrypt, 0 if exit
                verboseMode.vPrint("Option selected: " + option);
            
                if (option == 0){ //exits program
                    
                    repeat = false;
                    return;
                }
                if (option == 1){ 
                    encrypt encrypt = new encrypt();
                    string Message = encrypt.getString();
                    string encryptedMessage = encrypt.encryptString(Message);
                    Console.WriteLine("Encrypted message: " + encryptedMessage);
                    
                }
                if (option == 2){
                    decrypt decrypt = new decrypt();
                    string encryptedMessage = decrypt.getString();
                    string decryptedMessage = decrypt.DecryptMessage(encryptedMessage);
                    Console.WriteLine("Decrypted message: " + decryptedMessage);
                    
                }
            }

        
            
        }
    }
