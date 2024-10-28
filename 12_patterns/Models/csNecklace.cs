using Seido.Utilities.SeedGenerator;
using Models;

public class csNecklace
{
    private List<csPearl> Pearls {get; set;} = new List<csPearl>();
    private static csNecklace _instance = null;
    public static csNecklace Instance {get {
        if (_instance == null)
        {
            _instance = Factory.ZebraNecklace(5);
        }
        return _instance;
    }}

    public override string ToString(){
        
        string sRet = "";
        foreach (var item in Pearls)
        {
            sRet += $"{item}\n";
        }
        return sRet;
    }

    public csNecklace AddLast(csPearl p)
    {
        Pearls.Add(p);
        return this;
    }
    public csNecklace AddFirst(csPearl p) {
        Pearls.Insert(0, p);
        return this;
    }
    
    public csNecklace RemoveFirst() {
        if (Pearls.Count > 0)
        {
            Pearls.RemoveAt(0);
        }
        return this;
    }
    public csNecklace RemoveLast() {
        if (Pearls.Count > 0)
        {
            Pearls.RemoveAt(Pearls.Count-1);
        }
        return this;
    }

    private csNecklace(csSeedGenerator _seeder, int nrItems)
    {
        for (int i = 0; i < nrItems; i++)
        {
            Pearls.Add(new csPearl(_seeder));
        }
    }

    private csNecklace(csNecklace org)
    {
        foreach (var p in org.Pearls)
        {
            this.Pearls.Add(new csPearl(p));
        }
        //alternative
        //this.Pearls = org.Pearls.Select(p => new csPearl(p)).ToList();
    }

    private csNecklace()
    {
    }

    private static class Factory
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