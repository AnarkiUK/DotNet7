using System;
using System.Collections.Generic; //List<T>
using static System.Console;

namespace Packt.Shared;

public class Person
{
    // Fields
    // Public fields should be Pascal case
    public string Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavouriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new ();
    public const string Species = "Homo Sapien"; // Constant (won't ever change)
}
