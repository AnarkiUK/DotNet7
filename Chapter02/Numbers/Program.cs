// Unsigned integer means positive whole number or 0
uint naturalNumber = 23;
Console.WriteLine($"{nameof(naturalNumber)}: {naturalNumber}");

// Integer means negative or positive whole number or 0
int integerNumber = -23;
Console.WriteLine($"{nameof(integerNumber)}: {integerNumber}");

// Float means single-precision floating point
// F suffix makes it a float literal
float realNumber = 2.3F;
Console.WriteLine($"{nameof(realNumber)}: {realNumber}");

// Double means double-precision floating point
double anotherRealNumber = 2.3; // Double literal
Console.WriteLine($"{nameof(anotherRealNumber)}: {anotherRealNumber}");

// Three variables that store the number 2 million
// You can (but don't have to) use underscores (_) for legibility
int decimalNotation = 2_000_000;
Console.WriteLine($"{nameof(decimalNotation)}: {decimalNotation}");
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
Console.WriteLine($"{nameof(binaryNotation)}: {binaryNotation}");
int hexadecimalNotation = 0x_001E_8480;
Console.WriteLine($"{nameof(hexadecimalNotation)}: {hexadecimalNotation}");

// Check the three variables have the same value
// Both statements should output true
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

// Exploring number sizes
Console.WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers in the range {uint.MinValue:N0} to {uint.MaxValue:N0}.");
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

// Compare double and decimal types (because it looks like double is better by storing more for less!)
Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if(a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
// This shows that doubles are not guaranteed to be accurate
// Because some numbers, like 0.1, can't be represented as floating-point values
// Use double when accuracy isn't important (like only using < or > and not ==)
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("Using decimals:");
decimal c = 0.1M; // M suffix means a decimal literal value
decimal d = 0.2M;
// This shows that decimals are guaranteed to be accurate and can be used for == comparison
if(c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}