using System.Diagnostics;
using Helpers;

namespace _03_Pearls;

public enum enPearlColor { Black, White, Pink }
public enum enPearlShape { Round, DropShaped }
public enum enPearlType { FreshWater, SaltWater }

public class csPearl
{
    public const int PearlMinSize = 5;
    public const int PearlMaxSize = 25;

    public enPearlColor Color { get;  }
    public enPearlShape Shape { get;  }
    public enPearlType Type { get;  }

    int _size;
    public int Size
    {
        get => _size;
        set
        {
            if (value < PearlMinSize || value > PearlMaxSize)
                throw new ArgumentOutOfRangeException(nameof(Size));
            _size = value;
        }
    }

    public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";

    public csPearl()
    {
        var _seeder = new csSeedGenerator();
        Size = _seeder.Next(PearlMinSize, PearlMaxSize + 1);
        Color = _seeder.FromEnum<enPearlColor>();
        Shape = _seeder.FromEnum<enPearlShape>();
        Type = _seeder.FromEnum<enPearlType>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Perls!");

        //Create a necklace
        csPearl[] necklace = new csPearl[10];
        for (int i = 0; i < 10; i++)
        {
            necklace[i] = new csPearl();
        }

        //Find min and max pear
        int maxSize = int.MinValue;
        int maxIdx = 0;
        int minSize = int.MaxValue;
        int minIdx = 0;
        for (int i = 0; i < 10; i++)
        {
            if (necklace[i].Size > maxSize)
            {
                maxSize = necklace[i].Size;
                maxIdx = i;
            }
            if (necklace[i].Size < minSize)
            {
                minSize = necklace[i].Size;
                minIdx = i;
            }
        }

        //Present it to the user
        Console.WriteLine("\nThis is the neclace");
        foreach (var item in necklace)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Largest pearl: {necklace[maxIdx]}");
        Console.WriteLine($"Smalest pearl: {necklace[minIdx]}");
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
// --- Gör tills 4 Oktober
// 6. Gör om construtor csPearl() så att den tar en parameter (csSeedGenerator _seeder).
//    Instantiera csSeedGeneratorn i Main() och modifiera koden så att den fungerar som innan.
//
// 7. Deklarera en contruktor som tillåter dig att själv bestämma alla csPearl public properties
//
// 8. Deklarera en Copy constructor.
//
// 9. Använd copy constructorn för att skapa ett nytt halsband som är en kopia av ursprunget
