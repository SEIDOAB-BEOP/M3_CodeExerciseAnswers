using Seido.Utilities.SeedGenerator;

namespace Models;

public enum enPearlColor { Black, White, Pink }
public enum enPearlShape { Round, DropShaped }
public enum enPearlType { FreshWater, SaltWater }

public class csPearl
{
    public const int PearlMinSize = 5;
    public const int PearlMaxSize = 25;
    public int Size {get; set;}
    public enPearlColor Color { get;  init;}
    public enPearlShape Shape { get;  init;}
    public enPearlType Type { get;  init;}

    public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";

    public csPearl(csSeedGenerator _seeder)
    {
        Size = _seeder.Next(PearlMinSize, PearlMaxSize + 1);
        Color = _seeder.FromEnum<enPearlColor>();
        Shape = _seeder.FromEnum<enPearlShape>();
        Type = _seeder.FromEnum<enPearlType>();
    }
    public csPearl(int Size, enPearlColor color, enPearlShape shape, enPearlType type)
    {
       this.Size = Size;
       Color = color;
       Shape = shape;
       Type = type;
    }

    public csPearl(csPearl org)
    {
        Size = org.Size;
        Color = org.Color;
        Shape = org.Shape;
        Type = org.Type;
    }

}

