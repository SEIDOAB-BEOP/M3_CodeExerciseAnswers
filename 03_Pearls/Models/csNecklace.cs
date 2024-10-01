using Seido.Utilities.SeedGenerator;
using Models;

public class csNecklace
{
    public List<csPearl> Pearls {get; set;} = new List<csPearl>();

    public (csPearl max, csPearl min) MaxMin() {

        int _min = int.MaxValue;
        csPearl _minPearl = null;
        int _max = int.MinValue;
        csPearl _maxPearl = null;
        foreach (var p in Pearls)
        {
            if (p.Size < _min)
            {
                _min = p.Size;
                _minPearl = p;
            }
            if (p.Size > _max)
            { 
                _max = p.Size;
                _maxPearl = p;
            }
        }
        return (_maxPearl, _minPearl);
    }

    public override string ToString(){
        
        string sRet = "";
        foreach (var item in Pearls)
        {
            sRet += $"{item}\n";
        }
        return sRet;
    }

    public csNecklace(csSeedGenerator _seeder, int nrItems)
    {
        for (int i = 0; i < nrItems; i++)
        {
            Pearls.Add(new csPearl(_seeder));
        }
    }

    public csNecklace(csNecklace org)
    {
        foreach (var item in org.Pearls)
        {
            this.Pearls.Add(new csPearl(item));
        }
    }
}