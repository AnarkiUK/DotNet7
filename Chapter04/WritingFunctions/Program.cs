using static System.Console;

TimesTable(6);
// Could also be written: TimesTable(number: 6);

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "fr");
WriteLine($"Tax to pay: {taxToPay}");
WriteLine();
RunCardinalToOrdinal();
WriteLine();
RunFactorial();
WriteLine();
RunFibImperative();
WriteLine();
RunFibFunctional();

// Static method because the static Main method
static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table:");
    for(int row = 1; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}");
    }
    WriteLine();
}

static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = twoLetterRegionCode.ToUpper() switch
    {
        "CH" // Switzerland
            => 0.08M,
        "DK"// Denmark
            => 0.25M,
        "NO"// Norway
            => 0.25M,
        "GB" or "FR" // Great Britain or France
            => 0.2M,
        "HU" // Hungary
            => 0.27M,
        "OR" or "AK" or "MT" // Oregan, Alaska, or Montana
            => 0.0M,
        _ // default
            => 0.06M
    };
    return amount * rate;
}
// The line below uses /// to start an XML comment

/// <summary>
/// Pass a 32-bit integer and it will be convered into its ordinal equivalent.
/// </summary>
/// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on. </param>
/// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, 4th, and so on.</returns>
static string CardinalToOrdinal(int number)
{
    switch(number)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}


static void RunCardinalToOrdinal()
{
    for(int number = 1; number <= 40; number++)
    {
        Write($"{CardinalToOrdinal(number)} ");
    }
    WriteLine();
}

// This function uses recursion
static int Factorial(int number)
{
    if(number < 1)
    {
        return 0;
    }
    else if(number == 1)
    {
        return 1;
    }
    else
    {
        checked // Checking for overflow
        {
            return number * Factorial(number -1);
        }
    }
}

static void RunFactorial()
{
    for(int i = 1; i < 15; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch(System.OverflowException)
        {
            WriteLine($"{i} is too big for a 32-bit integer (that's not what she said).");
        }
    }
}

// Imperative function/method example
static int FibImperative(int term)
{
    if(term ==1)
    {
        return 0;
    }
    else if(term ==2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}

static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibImperative(term: i):N0}");
    }
}

// Declarative function/method example
static int FibFunctional(int term) =>
term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };

static void RunFibFunctional()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibFunctional(term: i)}");
    }
}

