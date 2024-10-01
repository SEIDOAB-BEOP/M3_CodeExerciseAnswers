using System;
using Seido.Utilities.SeedGenerator;

namespace Models
{
    public enum enGrapeType { Reissling, Tempranillo, Chardonay, Shiraz, CabernetSavignoin, Syrah }
    public enum enWineType { Red, White, Rose }
    public enum enCountry { Germany, France, Spain }

    public interface IWine
	{
        public string Name { get; set; }

        public enCountry Country { get; set; }
        public enWineType WineType { get; set; }
        public enGrapeType GrapeType { get; set; }
        public decimal Price { get; set; }
    }

    public interface IWineCellar
    {
        public string Name { get; set; }
        public List<IWine> Wines { get; set; }
        public void Add(IWine wine);
        public int Count {get;}
        public decimal Value { get;}

        public (IWine mostExpensive, IWine cheepest) WineHiLo(); 
    }
}

