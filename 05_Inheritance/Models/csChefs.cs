namespace Models;

public class csChef
{
    public string Name { get; set; } = "Boring";
    public int Age { get; set; } = 0;

    public virtual string Greeting => $"Hello";
    public string FavoriteDish { get; set; } = "nothing";

    public override string ToString() => $"{Greeting}, I am {Name}. I like {FavoriteDish}";

}

public class csFrenchChef : csChef
{
        public override string Greeting => $"BonJour";
}
public class csGermanChef : csChef
{
        public override string Greeting => $"Grussen Sie";
}
public class csItalianChef : csChef
{
        public override string Greeting => $"Ciao";
}