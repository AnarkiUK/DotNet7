using static System.Console;

bool a = true, b = false;

WriteLine($"AND |a |b ");
WriteLine($"a |{a & a, -5}|{a & b, -5}");
WriteLine($"b |{b & a, -5}|{b & b, -5}");
WriteLine();
WriteLine($"OR |a |b ");
WriteLine($"a |{a | a, -5}|{a | b, -5}");
WriteLine($"b |{b | a, -5}|{b | b, -5}");
WriteLine();
WriteLine("XOR |a |b");
WriteLine($"a |{a ^ a, -5}|{a ^ b, -5}");
WriteLine($"b |{b ^ a, -5}|{b ^ b, -5}");
WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStuff() = {b & DoStuff()}\n"); // Will run the method and then evaluate
WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine($"b && DoStuff() = {b && DoStuff()}"); // As b is false, the method won't run (short-circuit)

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}