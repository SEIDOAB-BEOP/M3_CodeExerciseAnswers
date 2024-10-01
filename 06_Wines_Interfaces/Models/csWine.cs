using System;
using Seido.Utilities.SeedGenerator;

namespace Models
{
        public class csWine : IWine
        {
                public string Name { get; set; }

                public enCountry Country { get; set; }
                public enWineType WineType { get; set; }
                public enGrapeType GrapeType { get; set; }

                public decimal Price { get; set; }

                public override string ToString()
                => $"Wine {Name} from {Country} is {WineType} and made from grapes {GrapeType}. The price is {Price:N2} Sek";


                public csWine (csSeedGenerator _seeder)
                {
                        Name = _seeder.FromString("Chattaux de bueff, Chattaux de paraply, PutiPuti, NamNam");

                        GrapeType = _seeder.FromEnum<enGrapeType>();
                        WineType = _seeder.FromEnum<enWineType>();
                        Country = _seeder.FromEnum<enCountry>();
                        Price = _seeder.NextDecimal(50, 150);
                }
        }  
}

