
// Statically importing System.Console to avoid having to write "Console"
using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1:pricePerApple * numberOfApples
);

string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine(
    format: "{0, -10} {1, 6:N0}",// Left justify the name and right justify the count
    arg0: "Name",
    arg1: "Count"
);
WriteLine(
    format: "{0, -10} {1, 6:N0}",
    arg0: applesText,
    arg1: applesCount
);
WriteLine(
    format: "{0, -10} {1, 6:N0}",
    arg0: bananasText,
    arg1: bananasCount
);

Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();
Write("Type your age and press ENTER: ");
string? age = ReadLine();
WriteLine($"Hello {firstName}, you look great for {age}!");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");