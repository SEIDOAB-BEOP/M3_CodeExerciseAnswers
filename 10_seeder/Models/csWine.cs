using Seido.Utilities.SeedGenerator;
namespace Models;

public enum enGrapeType { Reissling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah }
public enum enWineType { Red, White, Rose }
public enum enCountry { Germany, France, Spain }

public class csWine : ISeed<csWine>
{
    public string Name { get; set; }

    public enCountry Country { get; set; }
    public enWineType WineType { get; set; }
    public enGrapeType GrapeType { get; set; }

    public decimal Price { get; set; }

    public override string ToString()
        => $"Wine {Name} from {Country} is {WineType} and made from grapes {GrapeType}. The price is {Price:N2} Sek";


    #region implement ISeed
    public csWine(){}
    public bool Seeded { get; set; }
    public csWine Seed (csSeedGenerator rnd)
    {
        Name = rnd.FromString("Chattaux de bueff, Chattaux de paraply, PutiPuti, NamNam");

        GrapeType = rnd.FromEnum<enGrapeType>();
        WineType = rnd.FromEnum<enWineType>();
        Country = rnd.FromEnum<enCountry>();
        Price = rnd.Next(50, 150);
        return this;
    }
    #endregion

    #region Implementation of IEquatable<T> interface
    public bool Equals(csWine other) => (this.Name, this.GrapeType, this.WineType, this.Country, this.Price) ==
        (other?.Name, other?.GrapeType, other?.WineType, other?.Country, other?.Price);

    //Needed to implement as part of IEquatable
    public override bool Equals(object obj) => Equals(obj as csPearl);
    public override int GetHashCode() => (this.Name, this.GrapeType, this.WineType, this.Country, this.Price).GetHashCode();
    #endregion
}
