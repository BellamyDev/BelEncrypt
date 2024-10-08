public class letterEncrypt
{
    public static string encryptLetter(char letter)
    {
        string encryptedLetter;

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
            default:
                encryptedLetter = letter.ToString();
                break;
        }

        return encryptedLetter;
    }
        public static char DecryptLetter(string encryptedLetter)
    {
        char decryptedLetter = '\0';

        switch (encryptedLetter)
        {
            case "0x13r":
                decryptedLetter = 'a';
                break;
            case "0x24y":
                decryptedLetter = 'b';
                break;
            case "0x35x":
                decryptedLetter = 'c';
                break;
            case "0x46w":
                decryptedLetter = 'd';
                break;
            case "0x57v":
                decryptedLetter = 'e';
                break;
            case "0x68u":
                decryptedLetter = 'f';
                break;
            case "0x79t":
                decryptedLetter = 'g';
                break;
            case "0x80s":
                decryptedLetter = 'h';
                break;
            case "0x91r":
                decryptedLetter = 'i';
                break;
            case "0x02q":
                decryptedLetter = 'j';
                break;
            case "0x13p":
                decryptedLetter = 'k';
                break;
            case "0x24o":
                decryptedLetter = 'l';
                break;
            case "0x35n":
                decryptedLetter = 'm';
                break;
            case "0x46m":
                decryptedLetter = 'n';
                break;
            case "0x57l":
                decryptedLetter = 'o';
                break;
            case "0x68k":
                decryptedLetter = 'p';
                break;
            case "0x79j":
                decryptedLetter = 'q';
                break;
            case "0x80i":
                decryptedLetter = 'r';
                break;
            case "0x91h":
                decryptedLetter = 's';
                break;
            case "0x02g":
                decryptedLetter = 't';
                break;
            case "0x13f":
                decryptedLetter = 'u';
                break;
            case "0x24e":
                decryptedLetter = 'v';
                break;
            case "0x35d":
                decryptedLetter = 'w';
                break;
            case "0x46c":
                decryptedLetter = 'x';
                break;
            case "0x57b":
                decryptedLetter = 'y';
                break;
            case "0x68a":
                decryptedLetter = 'z';
                break;
            default:
                decryptedLetter = '\0';
                break;
        }

        return decryptedLetter;
    }
}
