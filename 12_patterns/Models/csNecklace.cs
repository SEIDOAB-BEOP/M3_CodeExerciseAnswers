using Seido.Utilities.SeedGenerator;
using Models;

public class csNecklace
{
    private List<csPearl> Pearls {get; set;} = new List<csPearl>();

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
        foreach (var p in org.Pearls)
        {
            this.Pearls.Add(new csPearl(p));
        }
        //alternative
        //this.Pearls = org.Pearls.Select(p => new csPearl(p)).ToList();
    }

    public csNecklace()
    {
    }

    public static class Factory
    {
        public static csNecklace ZebraNecklace (int nrPearls)
        {
            var n = new csNecklace();
            for (int i = 0; i < nrPearls; i++)
            {
                if (i%3 == 0)
                {
                    n.Pearls.Add(new csPearl(){ Color = enPearlColor.Black, Size = csPearl.PearlMaxSize});
                }
                else
                {
                    n.Pearls.Add(new csPearl(){ Color = enPearlColor.White, Size = csPearl.PearlMinSize});
                }
            }
            return n;
        }
    }
}