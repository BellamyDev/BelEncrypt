public class letterEncrypt
{
    // Encrypts a letter or wraps a number between '%' characters
    public static string encryptLetter(char letter)
    {
        string encryptedLetter;

        if (char.IsDigit(letter))
        {
            // Wrap the number in '%' and return it as is
            return $"%{letter}%";
        }

        // Switch statement for encrypting lowercase letters and space
        switch (letter)
        {
            case 'a':
                encryptedLetter = "0x13r";
                break;
            case 'b':
                encryptedLetter = "0x24y";
                break;
            case 'c':
                encryptedLetter = "0x35x";
                break;
            case 'd':
                encryptedLetter = "0x46w";
                break;
            case 'e':
                encryptedLetter = "0x57v";
                break;
            case 'f':
                encryptedLetter = "0x68u";
                break;
            case 'g':
                encryptedLetter = "0x79t";
                break;
            case 'h':
                encryptedLetter = "0x80s";
                break;
            case 'i':
                encryptedLetter = "0x91r";
                break;
            case 'j':
                encryptedLetter = "0x02q";
                break;
            case 'k':
                encryptedLetter = "0x13p";
                break;
            case 'l':
                encryptedLetter = "0x24o";
                break;
            case 'm':
                encryptedLetter = "0x35n";
                break;
            case 'n':
                encryptedLetter = "0x46m";
                break;
            case 'o':
                encryptedLetter = "0x57l";
                break;
            case 'p':
                encryptedLetter = "0x68k";
                break;
            case 'q':
                encryptedLetter = "0x79j";
                break;
            case 'r':
                encryptedLetter = "0x80i";
                break;
            case 's':
                encryptedLetter = "0x91h";
                break;
            case 't':
                encryptedLetter = "0x02g";
                break;
            case 'u':
                encryptedLetter = "0x13f";
                break;
            case 'v':
                encryptedLetter = "0x24e";
                break;
            case 'w':
                encryptedLetter = "0x35d";
                break;
            case 'x':
                encryptedLetter = "0x46c";
                break;
            case 'y':
                encryptedLetter = "0x57b";
                break;
            case 'z':
                encryptedLetter = "0x68a";
                break;
            case ' ':
                encryptedLetter = "0x00s"; // Encrypted representation for space
                break;
            default:
                encryptedLetter = letter.ToString(); // Include unsupported characters unencrypted
                break;
        }

        return encryptedLetter;
    }

    // Decrypts an encrypted letter or extracts the number wrapped in '%' characters
    public static string DecryptLetter(string encryptedLetter)
    {
        if (encryptedLetter.StartsWith("%") && encryptedLetter.EndsWith("%"))
        {
            // If the encryptedLetter is wrapped in %, it's a number
            if (encryptedLetter.Length == 3) // Ensure it's in format %X%
            {
                return encryptedLetter[1].ToString(); // Extract the number between the '%' signs
            }
            else
            {
                return encryptedLetter; // Return as is (could not decrypt)
            }
        }

        // Switch statement for decrypting letters and space
        switch (encryptedLetter)
        {
            case "0x13r":
                return "a";
            case "0x24y":
                return "b";
            case "0x35x":
                return "c";
            case "0x46w":
                return "d";
            case "0x57v":
                return "e";
            case "0x68u":
                return "f";
            case "0x79t":
                return "g";
            case "0x80s":
                return "h";
            case "0x91r":
                return "i";
            case "0x02q":
                return "j";
            case "0x13p":
                return "k";
            case "0x24o":
                return "l";
            case "0x35n":
                return "m";
            case "0x46m":
                return "n";
            case "0x57l":
                return "o";
            case "0x68k":
                return "p";
            case "0x79j":
                return "q";
            case "0x80i":
                return "r";
            case "0x91h":
                return "s";
            case "0x02g":
                return "t";
            case "0x13f":
                return "u";
            case "0x24e":
                return "v";
            case "0x35d":
                return "w";
            case "0x46c":
                return "x";
            case "0x57b":
                return "y";
            case "0x68a":
                return "z";
            case "0x00s":
                return " "; 
            default:
                return encryptedLetter; // Return as is for unsupported characters
        }
    }
}
