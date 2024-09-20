public class verboseMode
{
    public static bool verbose = false;
    public static void setVerbose(bool value)
    {
        verbose = value;
    }
    public static bool getVerbose()
    {
        return verbose;
    }
    public static void vPrint(string message)
    {
        if (verbose)
        {
            Console.WriteLine(message);
        }
    }
}