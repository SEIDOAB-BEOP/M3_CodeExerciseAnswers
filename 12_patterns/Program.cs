// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("12_patterns!");
var _seeder = new csSeedGenerator();


//var zn = csNecklace.Factory.ZebraNecklace(10);
var zn = csNecklace.Instance;
System.Console.WriteLine(zn);

System.Console.WriteLine("\nTest Add and remove");
System.Console.WriteLine(
   zn.RemoveFirst().AddFirst(new csPearl(_seeder) { Color = enPearlColor.Pink})
   .RemoveLast().AddLast(new csPearl(_seeder) { Color = enPearlColor.Pink})
);


var necklace1 = csNecklace.Instance;
var necklace2 = csNecklace.Instance;

necklace1.RemoveFirst().RemoveLast().AddFirst(new csPearl(_seeder) { Color = enPearlColor.Pink});

System.Console.WriteLine(necklace1);
System.Console.WriteLine(necklace2);
/* Exercises 

1. Implement copy contructors on csPearl and csNecklace
2. Implement a class factory that creates a Zebra necklace och black and white pearls.
   One large black pearls (20mm) followed by two small white pearls (10mm) in a repetive pattern for X nr of pearls

3. Implement a method AddFirst(csPearl p), AddLast(csPearl p),  RemoveFirst(csPearl p), RemoveLast(csPearl p) that
   that uses Fluent syntax.
4. Use the methods to change the first two pearls and last two pearls to two small pink (3mmm) pearls

5. Implement csNecklace to be a Singleton, i.e ones a Zebra necklace is created all other calls to to 
   Zebra necklace shall give the same instance.
   Do the following steps peeking at M3_08_05
      - private static field _instace
      - public static get property Instance that:
          if _instance is null creates a ZebraNecklace with 20 pearls
          if _instance is not null returns the instance
      - make all constructors private

6. Test by doing necklace1 = csNeclace.Instance; and necklace2 = csNeclace.Instance;
7. Try adding and removing pearls from necklace1. You will see the changes also reflected in necklace2
*/ 
