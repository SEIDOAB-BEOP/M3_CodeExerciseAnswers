using System;
using System.Dynamic;
using Seido.Utilities.SeedGenerator;

namespace Models
{
    public class csWineCellar : IWineCellar
    {
        public string Name { get; set; }
        public List<IWine> Wines { get; set; } = new List<IWine>();

        public int Count => Wines.Count;

        public decimal Value {
            get {

                decimal _sum = 0M;
                foreach (var wine in Wines) {

                    _sum += wine.Price;
                }

                return _sum;
            }
        }

        public override string ToString()
        {
            var sRet = $"\nCellar {Name} has {Count} bottles:";
            foreach (var wine in Wines)
            {
                sRet += $"\n -{wine}";
            }
            return sRet;
        }

        public csWineCellar() { }
        public csWineCellar(string cellarname, csSeedGenerator _seeder, int nrItems)
        {
            Name = cellarname;
            for (int i = 0; i < nrItems; i++)
            {
                Wines.Add(new csWine(_seeder));
            }
        }
        public csWineCellar(string cellarname, List<IWine> wines)
        {
            Name = cellarname;
            Wines = wines;
        }

        public void Add(IWine wine) => Wines.Add(wine);

        public (IWine mostExpensive, IWine cheepest) WineHiLo()
        {
           if (Wines.Count == 0) return (null,null);

            decimal _hiPrice = decimal.MinValue;
            IWine _hiWine = null;
            decimal _loPrice = decimal.MaxValue;
            IWine _loWine = null;
            foreach (var wine in Wines)
            {
                if (wine.Price > _hiPrice)
                {
                    _hiWine = wine;
                    _hiPrice = wine.Price;
                }
                if (wine.Price < _loPrice)
                {
                    _loWine = wine;
                    _loPrice = wine.Price;
                }
            }
            return (_hiWine, _loWine);
        }
    }
}

