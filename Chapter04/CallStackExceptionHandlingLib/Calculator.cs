using static System.Console;

namespace Packt;
public class Calculator
{
    public static void Gamma() // Public so it can be called from the outside
    {
        WriteLine("In Gamma");
        Delta();
    }
    private static void Delta() // Private so it can only be called internally
    {
        WriteLine("In Delta");
        File.OpenText("bad file path");
    }
}
