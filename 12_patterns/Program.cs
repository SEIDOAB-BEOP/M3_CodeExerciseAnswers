// See https://aka.ms/new-console-template for more information
using Seido.Utilities.SeedGenerator;

Console.WriteLine("12_patterns!");
var _seeder = new csSeedGenerator();


var zn = csNecklace.Factory.ZebraNecklace(10);
System.Console.WriteLine(zn);



/* Exercises 

1. Implement copy contructors on csPearl and csNecklace
2. Implement a class factory that creates a Zebra necklace och black and white pearls.
   One large black pearls (20mm) followed by two small white pearls (10mm) in a repetive pattern for X nr of pearls

3. Implement a method AddFirst(csPearl p), AddLast(csPearl p),  RemoveFirst(csPearl p), RemoveLast(csPearl p) that
   that uses Fluent syntax.
4. Use the methods to change the first two pearls and last two pearls to two small pink (3mmm) pearls

5. Implement csNecklace to be a Singleton, i.e ones a Zebra necklace is created all other calls to to 
   Zebra necklace shall give the same instance

*/ 
