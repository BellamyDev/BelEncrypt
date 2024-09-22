public class letterEncyrpt{
    public static string encryptLetter(char letter){
        string encryptedLetter;
       
        switch (letter)
        {
            case 'a':
                encryptedLetter = "z";
                return encryptedLetter;
                break;
            case 'b':
                encryptedLetter = "y";
                break;
            case 'c':
                encryptedLetter = "x";
                break;
            case 'd':
                encryptedLetter = "w";
                break;
            case 'e':
                encryptedLetter = "v";
                break;
            case 'f':
                encryptedLetter = "u";
                break;
            case 'g':
                encryptedLetter = "t";
                break;
            case 'h':
                encryptedLetter = "s";
                break;
            case 'i':
                encryptedLetter = "r";
                break;
            case 'j':
                encryptedLetter = "q";
                break;
            case 'k':
                encryptedLetter = "p";
                break;
            case 'l':
                encryptedLetter = "o";
                break;
            case 'm':
                encryptedLetter = "n";
                break;
            case 'n':
                encryptedLetter = "m";
                break;
            case 'o':
                encryptedLetter = "l";
                break;
            case 'p':
                encryptedLetter = "k";
                break;
            case 'q':
                encryptedLetter = "j";
                break;
            case 'r':
                encryptedLetter = "i";
                break;
            case 's':
                encryptedLetter = "h";
                break;
            case 't':
                encryptedLetter = "g";
                break;
            case 'u':
                encryptedLetter = "f";
                break;
            case 'v':
                encryptedLetter = "e";
                break;
            case 'w':
                encryptedLetter = "d";
                break;
            case 'x':
                encryptedLetter = "c";
                break;
            case 'y':
                encryptedLetter = "b";
                break;
            case 'z':
                encryptedLetter = "a";
                break;
            default:
                encryptedLetter = letter.ToString();
                break;
        }
        
    }
}