using Helpers;

namespace _04_Wines;

public enum enGrapeType {Reissling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah}
public enum enWineType { Red, White, Rose}
public enum enCountry { Germany, France, Spain }

public class csWine
{
    public string Name { get; }

    public enCountry Country { get; }
    public enWineType WineType { get; }
    public enGrapeType GrapeType { get; }

    public decimal Price { get; set; }

    public override string ToString()
    {
        var s = $"Wine {Name} from {Country} is {WineType} and made from grapes {GrapeType}. The price is {Price:N2} Sek";
        return s;
    }
    
    public csWine()
    {
        var rnd = new csSeedGenerator();

        string[] _names = "Chattaux de bueff, Chattaux de paraply, PutiPuti".Split(", ");
        Name = _names[rnd.Next(0, _names.Length)];

        GrapeType = rnd.FromEnum<enGrapeType>();
        WineType = rnd.FromEnum<enWineType>();
        Country = rnd.FromEnum<enCountry>();
        Price = rnd.Next(50, 150);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Wine World!");

        Console.WriteLine("A Single bottle");
        var wine1 = new csWine();
        wine1.Price = 70M;
        Console.WriteLine(wine1);

        Console.WriteLine("\nA wine cellar");
        csWine[] wines = new csWine[10];
        
        for (int i = 0; i < wines.Length; i++)
        {
            wines[i] = new csWine();
        }
        
        for (int i = 0; i < wines.Length; i++)
        {
            Console.WriteLine(wines[i]);
        }

        decimal maxPrice = decimal.MinValue;
        decimal minPrice = decimal.MaxValue;
        decimal totValue = 0;
        for (int i = 0; i < wines.Length; i++)
        {
            if (wines[i].Price > maxPrice )
            {
                maxPrice = wines[i].Price;
            }
            if (wines[i].Price < minPrice)
            {
                minPrice = wines[i].Price;
            }

            totValue += wines[i].Price;
        }
        Console.WriteLine();
        Console.WriteLine($"My most expensive wine cost {maxPrice}");
        Console.WriteLine($"My most cheapest wine cost {minPrice}");
        Console.WriteLine($"Total wine cellar value is {totValue}");
    }
}

//Exercise:
// 1. Modellera en flaska vin en C# class. Utmärkande för ett vin är
//    Druva: Reissling, Tempranillo, Chardonay, Shiraz, Cabernet Savignoin, Syrah
//    Typ: Rött, vitt, rose
//    Namn: namnet på vinet
//    Land: Tyskland, Frankrike, Spanien
//    Pris:
//
// 2. När vinet väl är skapad så ska man bara kunna ändra pris.
//
// 3. Skapa en ToString i din vinklass som presenterar vinet.
//
// 4. Skapa en vinkällare bestående av 10 flaskor av slumpmässig Druva,
//    Typ, Namn, Land och pris
//
// 5. Vilket är det billigaste och dyraste vinet i vinkällaren?
//
// 7. Vad är värdet av vinkällaren?

