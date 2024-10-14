using Seido.Utilities.SeedGenerator;
namespace Models;

public enum enPearlColor { Black, White, Pink }
public enum enPearlShape { Round, DropShaped }
public enum enPearlType { FreshWater, SaltWater }

public class csPearl : ISeed<csPearl>, IEquatable<csPearl>
{
    public int Size { get; set; }
    public enPearlColor Color { get; set; }
    public enPearlShape Shape { get; set; }
    public enPearlType Type { get; set; }

    public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";


    public csPearl(int _size, enPearlColor _color, enPearlShape _shape, enPearlType _type)
    {
        Size = _size;
        Color = _color;
        Shape = _shape;
        Type = _type;
    }


    #region implement ISeed
    public csPearl() { }
    public bool Seeded { get; set; }

    public csPearl Seed(csSeedGenerator _seeder)
    {
        Size = _seeder.Next(5, 25);
        Color = _seeder.FromEnum<enPearlColor>();
        Shape = _seeder.FromEnum<enPearlShape>();
        Type = _seeder.FromEnum<enPearlType>();

        return this;
    }
    #endregion

    #region Implementation of IEquatable<T> interface
    public bool Equals(csPearl other) => (this.Size, this.Color, this.Shape, this.Type) ==
        (other?.Size, other?.Color, other?.Shape, other?.Type);

    //Needed to implement as part of IEquatable
    public override bool Equals(object obj) => Equals(obj as csPearl);
    public override int GetHashCode() => (this.Size, this.Color, this.Shape, this.Type).GetHashCode();
    #endregion
}


