
using System.Security.Cryptography.X509Certificates;

class Program
    {
        static void Main(string[] args)
        {
            int option;
            option = startMenu.start();//returns 1 if encrypt, 2 if decrypt, 0 if exit
            verboseMode.vPrint("Option selected: " + option);
            
            if (option == 0){ //exits program
                return;
            }

        
            
        }
    }
