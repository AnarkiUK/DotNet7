//#error version
using System.Reflection;

// Declare some unused variables using types in additional assemblies
System.Data.DataSet ds;
HttpClient client;

Assembly? assembly = Assembly.GetEntryAssembly();
if(assembly == null) return;

// Loop through the assemblies that this app references
foreach(AssemblyName name in assembly.GetReferencedAssemblies())
{
    // Load the assembly so we can read its details
    Assembly a = Assembly.Load(name);
    
    // Declare a variable to count the number of methods
    int methodCount = 0;
    
    // Loop through all types in the assembly
    foreach(TypeInfo t in a.DefinedTypes)
    {
        // Add up the counts of methods
        methodCount += t.GetMethods().Count();
    }
    // Output the count of types and their methods
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name
    );
}