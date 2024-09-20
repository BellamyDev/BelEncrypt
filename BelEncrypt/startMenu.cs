using System.Runtime.InteropServices;

public class startMenu
{
    public static int start()
    {
        string option;
        bool repeat = true;
        int value = 0;
        while (repeat == true)
        {
            Console.WriteLine("Welcome to BelEncrypt!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Encrypt a file");
            Console.WriteLine("2. Decrypt a file");
            Console.WriteLine("3. Toggle verbose mode");
            Console.WriteLine("4. Exit");
            Console.Write("Option: ");
            //Will repeat until a valid option is selected or the program is exited
            //Will also repeat if verbose mode is toggled
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("You selected Encrypt a file");
                    repeat = false; 
                    value = 1;
                    
                    break;
                    
                case "2":
                    Console.WriteLine("You selected Decrypt a file");
                    repeat = false;
                    value = 2;
                    break;
                case "3":
                    Console.WriteLine("You toggled verbose mode");
                    repeat = true;
                    verboseMode.setVerbose(!verboseMode.getVerbose());
                    break;
                case "4":
                    Console.WriteLine("Thanks for using BelEncrypt!");
                    repeat = false;
                    value = 0;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.Write("Option: ");
                    option = Console.ReadLine();
                    
                    break;
            }
        
        }
        return value;
    }
}