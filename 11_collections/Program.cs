// See https://aka.ms/new-console-template for more information
using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello, Collections1!");
var rnd = new csSeedGenerator();

//Instantiate and initialize a list
var ints1 = new List<int>();
for (int i = 0; i < 100; i++)
{
    ints1.Add(rnd.Next(0,100));
}

//Create deep copies
var ints2 = ints1.Select(i => i).ToList();

//Sort the list
System.Console.WriteLine("\nSorted List");
ints1.Sort();
System.Console.WriteLine($"{nameof(ints1)} contains {ints1.Count} ints");
ints1.ForEach(i => System.Console.WriteLine(i));

//Shuffle the list
System.Console.WriteLine("\nShuffled List");
for (int i = 0; i < 1000; i++)
{
    var idx1 = rnd.Next(0, ints1.Count);
    var idx2 = rnd.Next(0, ints1.Count);
    
    ///swap using tupples
    (ints1[idx1], ints1[idx2]) = (ints1[idx2], ints1[idx1]);
}
System.Console.WriteLine($"{nameof(ints1)} contains {ints1.Count} ints");
ints1.ForEach(i => System.Console.WriteLine(i));


//Get unique ints
System.Console.WriteLine("\nUnique items List");
var intsUnique = new HashSet<int>(ints1);
System.Console.WriteLine($"{nameof(intsUnique)} contains {intsUnique.Count} ints");
intsUnique.ToList().ForEach(i => System.Console.WriteLine(i));

//Does the list contain duplicates?
System.Console.WriteLine($"\n{nameof(ints1)} contains duplicates: {false}");

//Use Dictionary to Get Nr of pieces of each int
System.Console.WriteLine("\nNr of pieces of each ints");
var nrInts = new Dictionary<int, int>();
ints2.ForEach (p => {
    if (nrInts.ContainsKey(p))
    {
         nrInts[p]++;
    }
    else
    {
        nrInts.Add(p, 1);
    }
});
nrInts.ToList().ForEach(item => System.Console.WriteLine($"{item.Value}pcs of {item.Key}"));


//List only duplicates
System.Console.WriteLine("\nDuplicates");
var intsDuplicates = new List<int>();
nrInts.ToList().ForEach(item => 
{
    if (item.Value >= 2)
    {
        intsDuplicates.Add(item.Key);
    }
});

intsDuplicates.ForEach(i => System.Console.WriteLine(i));
System.Console.WriteLine($"{nameof(intsDuplicates)} contains {intsDuplicates.Count} ints");


//Does the list contain pairs, tripplets, quad?
System.Console.WriteLine($"\n{nameof(ints1)} contains pairs: {false}");
System.Console.WriteLine($"\n{nameof(ints1)} contains tripplets: {false}");
System.Console.WriteLine($"\n{nameof(ints1)} contains quads: {false}");



/* Exercises
1. From main create and checkout a new Git branch called my_11_collections1
2. Study above code using the debugger understand what happens
3. Verify that ints2 is really a deep copy of ints1
4. Answer below questions
    - What interface is needed to be implemented to use ints1.Sort()?
    - Why is it not needed to be implemented by you in this example?
5. Instead of using tupples to swap on line 31, code a swap using a temporary variable.
6. On line 39 change HashSet to SortedSet and see the difference in output.
7. On line 44 replace {false} with code that gives true of ints2 contains duplicates, otherwise false
8. Understand Dictionary ContainsValue.
   https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.containsvalue?view=net-8.0
9. On line 78 - 80 replace {false} with code that answers the questions with true or false
   - test it by changing the content of ints1 or by increasing the number of random integers

10. From my_11_collections1 create and checkout a new Git branch called my_11_collections2
11. Study the Model csWine and modify above code to use a List<csWine> instead of List<int>
*/