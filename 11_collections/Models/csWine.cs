using Seido.Utilities.SeedGenerator;
namespace Models;

public enum enGrapeType { Reissling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah }
public enum enWineType { Red, White, Rose }
public enum enCountry { Germany, France, Spain }

public class csWine : ISeed<csWine>, IEquatable<csWine>, IComparable<csWine>
{
    public string Name { get; set; }

    public enCountry Country { get; set; }
    public enWineType WineType { get; set; }
    public enGrapeType GrapeType { get; set; }

    public override string ToString()
        => $"Wine {Name} from {Country} is {WineType} and made from grapes {GrapeType}";


    #region implement ISeed
    public csWine(){}
    public bool Seeded { get; set; } = false;
    public csWine Seed (csSeedGenerator rnd)
    {
        Name = rnd.FromString("Chattaux de bueff, Chattaux de paraply, PutiPuti, NamNam");

        GrapeType = rnd.FromEnum<enGrapeType>();
        WineType = rnd.FromEnum<enWineType>();
        Country = rnd.FromEnum<enCountry>();
        return this;
    }
    #endregion

    #region Implementation of IEquatable<T> interface
    public bool Equals(csWine other) => (this.Name, this.GrapeType, this.WineType, this.Country) ==
        (other?.Name, other?.GrapeType, other?.WineType, other?.Country);

    //Needed to implement as part of IEquatable
    public override bool Equals(object obj) => Equals(obj as csWine);
    public override int GetHashCode() => (this.Name, this.GrapeType, this.WineType, this.Country).GetHashCode();
    #endregion

    #region Implementation IComparable<T> interface
    public int CompareTo(csWine other)
    {
        if (this.Country != other.Country)
            return this.Country.CompareTo(other.Country);

        if (this.WineType != other.WineType)
            return this.WineType.CompareTo(other.WineType);

        if (this.GrapeType != other.GrapeType)
            return this.GrapeType.CompareTo(other.GrapeType);
        
        return this.Name.CompareTo(other.Name);
    }
    #endregion
}
