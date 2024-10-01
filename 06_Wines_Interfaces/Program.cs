using System.Xml.Linq;
using Seido.Utilities.SeedGenerator;
using Models;
using System.ComponentModel;

namespace _05_Wines_Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Wines with Interface!");
        var rnd = new csSeedGenerator();

        //IWineCellar wineCellar = null;
        IWineCellar wineCellar = new csWineCellar("Martin's wine cellar", rnd, 20);

        Console.WriteLine($"\nWinecellar:");
        Console.WriteLine(wineCellar);

        Console.WriteLine($"Nr of bottles in  winecellar: {wineCellar?.Count}");
        Console.WriteLine($"Value of winecellar: {wineCellar?.Value:N2} Sek");

        var hilo = wineCellar?.WineHiLo();
        Console.WriteLine($"\nMost expensive wine:\n{hilo?.mostExpensive}");
        Console.WriteLine($"Least expensive wine:\n{hilo?.cheepest}");

        System.Console.WriteLine("\nAdd a bottle to the cellar");
        //IWine wine = null;
        IWine wine = new csWine(rnd);

        wineCellar?.Add(wine);
        System.Console.WriteLine(wine);
        Console.WriteLine($"Nr of bottles in  winecellar: {wineCellar?.Count}");
        Console.WriteLine($"Value of winecellar: {wineCellar?.Value:N2} Sek");



    }
}

/* Exercises
1. Study the code and notice that you can both build and run even as the classes are not implemented.
   Discuss an understand the program output

2. code csWine to implement IWine and csWineCellar to implement IWinecellar 
3. Make sure you can build without error.

4. Make  ONLY TWO change in Program.cs
    - to instantiate IWineCellar wineCellar
    - to instantiate IWine wine
*/

