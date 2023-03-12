using Packt.Shared;
using static System.Console;

BankAccount.InterestRate = 0.012M; // Store a shared value

// Since C# 9.0, we no longer have to use Person bob = new Person();
Person bob = new();

bob.Name = "Bob Smith";
bob.DateOfBirth = new(1965, 12, 22);
bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
// Using bitwise logical OR to combine the enum values
// We could have also used bob.BucketList = (WondersOfTheAncientWorld)18; but that's harder to understand
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.Children.Add(new() { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach(Person child in bob.Children)
{
    WriteLine($" {child.Name}");
}
    WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM yyyy}");
WriteLine($"{bob.Name}'s favourite wonder is {bob.FavouriteAncientWonder}. Its integer is {(int)bob.FavouriteAncientWonder}");
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}\n");

// Shorthand object initialiser example
Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};
WriteLine($"{alice.Name} was born on {alice.DateOfBirth:ddd, dd MMM yy}");
WriteLine($"{alice.Name} is a {Person.Species}.\n");

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest.");

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C} interest.");