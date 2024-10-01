using System;
using System.Security.Cryptography;
using System.Text;
using Models;
using Seido.Utilities.SeedGenerator;

namespace _03_Pearls;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Pearls!");
        var _seeder = new csSeedGenerator();

        var p = new csPearl(_seeder);
        var p1 = new csPearl(_seeder) { Type = enPearlType.SaltWater };
        var p2 = new csPearl(7, enPearlColor.White, enPearlShape.DropShaped, enPearlType.SaltWater);
        System.Console.WriteLine(p);
        System.Console.WriteLine(p1);
        System.Console.WriteLine(p2);

        System.Console.WriteLine("Reference copy");
        var p3 = p2;
        p3.Size = 20;
        System.Console.WriteLine(p2);
        System.Console.WriteLine(p3);

        System.Console.WriteLine("Deep copy");
        var p4 = new csPearl(p2);
        p4.Size = 5;
        System.Console.WriteLine(p2);
        System.Console.WriteLine(p4);
        
        
        System.Console.WriteLine("\nNecklace");
        var n = new csNecklace(_seeder, 10);
        System.Console.WriteLine(n);

        var n1 = new csNecklace(n);
        System.Console.WriteLine(n1);

        (csPearl pmin, csPearl pmax) = n1.MaxMin();
        System.Console.WriteLine(pmin);
        System.Console.WriteLine(pmax);
    }
}

//Exercise:
// 1. Modellera en pärlan i en C# class. Utmärkande för en pärla är
//    Storlek: Diameter 5mm till 25mm
//    Färg: Svart, Vit, Rosa
//    Form: Rund, Droppformad
//    Typ: Sötvatten, Saltvatten
//
// 2. När pärlan väl är skapad så ska man inte kunna ändra den.
//
// 3. Skapa en ToString i din pärlklass som presenterar pärlan.
//
// 4. Skapa ett halsband bestående av 10 pärlor av slumpmässig storlek, färg
//    form, och typ
//
// 5. Vilken färg, form och typ har den minsta och den största pärlan i halsbandet?
//
// 6. Deklarera en contruktor som tillåter dig att själv bestämma alla csPearl public properties
//
// 7. Deklarera en Copy constructor.
//
// 8. Använd copy constructorn för att skapa ett nytt halsband som är en kopia av ursprunget



