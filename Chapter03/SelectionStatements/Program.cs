
using static System.Console;

string password = "ninja";
if(password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
    WriteLine("Your password is strong.");
}

// Add and remove the "" to change the behaviour
object o = "3";
int j = 4;
// Only if o is an int will the value be assigned to the local variable i (pattern matching)
// This is safter than using the o variable because we know for sure
// that i is an int variable and not something else.
if(o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot be multiplied.");
}

string path = @"D:\Repos\CSharpStudies\Chapter03";
Write("Press R for read-only or W for writeable: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
Stream? s;
if(key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read
    );
}
else
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write
    );
}
string message;
switch(s)
{
    case FileStream writeableFile when s.CanWrite: // Will only match if it's a FileStream and its CanWrite property is true
        message = "The stream is a file that I can write to.";
        s.Dispose();
        break;
    case FileStream readOnlyFile:
        message = "The stream is a read-only file.";
        s.Dispose();
        break;
    case MemoryStream memoryStream:
        message = "The stream is a memory address.";
        s.Dispose();
        break;
    default: // Always evaluated last
        message = "The stream is some other type.";
        s.Dispose();
        break;
    case null:
        message = "The stream is null.";
        break;
}
WriteLine(message);

// Using switch expressions to simplify
message = s switch
{
    FileStream writeableFile when s.CanWrite
        => "The stream is a file that I can write to.", // Assign this string to the message variable
    FileStream readOnlyFile
        => "The stream is a read-only file.",
    MemoryStream memoryStream
        => "The stream is a memory address.",
    null
        => "The stream is null.",
    _ //Same as default
        => "The stream is some other type."
};
WriteLine(message);

if(null != s)
{
    Write("Press any key to delete the file...");
    s.Dispose();
    ReadKey();
    File.Delete(Path.Combine(path, "file.txt"));
}


