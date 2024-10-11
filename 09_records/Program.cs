using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello Pearls!");
var _seeder = new csSeedGenerator();

var p = new rePearl(enPearlColor.Pink, enPearlShape.Round, enPearlType.SaltWater, 10);
System.Console.WriteLine(p);

var rp = new rePearl(_seeder.FromEnum<enPearlColor>(),_seeder.FromEnum<enPearlShape>(), _seeder.FromEnum<enPearlType>(), _seeder.Next(5,26));
System.Console.WriteLine(rp);

var rps = new rePearl(_seeder);
System.Console.WriteLine(rps);

//List of pearls
var pearls = new List<rePearl>();
for (int i = 0; i < 10; i++)
{
    pearls.Add(new rePearl(_seeder));
}

//Present the pearls
foreach (var item in pearls)
{
    System.Console.WriteLine(item);;
}


//Exercise:
// 1. Modellera en pärlan i en C# record. Utmärkande för en pärla är
//    Storlek: Diameter 5mm till 25mm
//    Färg: Svart, Vit, Rosa
//    Form: Rund, Droppformad
//    Typ: Sötvatten, Saltvatten
//
// 2. När pärlan väl är skapad så ska man inte kunna ändra den.
//
// 4. Skapa ett lista bestående av 10 pärlor av slumpmässig storlek, färg
//    form, och typ
//
// 5. Skriv ut listan
