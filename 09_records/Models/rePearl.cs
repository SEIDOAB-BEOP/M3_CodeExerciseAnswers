using Seido.Utilities.SeedGenerator;
namespace Models;

public enum enPearlColor { Black, White, Pink }
public enum enPearlShape { Round, DropShaped }
public enum enPearlType { FreshWater, SaltWater }

public record rePearl(enPearlColor Color, enPearlShape Shape, int Size)
{
    public rePearl(csSeedGenerator _seeder):this(_seeder.FromEnum<enPearlColor>(), _seeder.FromEnum<enPearlShape>(), _seeder.Next(5, 26))
    {}
}


