//#error version

// Example of a raw string literal
// The number of $ signs tells the compiler how many {} together to ignore
string json = $$"""
{
    "first_name": "Paul",
    "calculation": {{{30 + 5}}}
}
""";

// Example of a verbatim string
string verbatim = @"C:\t";

// Example of an interpolated string
string interp = $"My age is {30 + 5}";

Console.WriteLine(json);
Console.WriteLine(verbatim);
Console.WriteLine(interp);