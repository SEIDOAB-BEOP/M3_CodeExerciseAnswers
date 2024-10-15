using Seido.Utilities.SeedGenerator;
namespace Models;

public enum enCarColor { Brown, Red, Green, Burgundy}
public enum enCarBrand { Boxcar, Ford, Jaguar, Honda}
public enum enCarModel { Boxmodel, Mustang_GT, XF, Civic}

public class csCar : ISeed<csCar>, IEquatable<csCar>
{
    public enCarColor Color {get; set;}
    public enCarBrand Brand {get; set;}
    public enCarModel Model {get; set;}
    
    public override string ToString() => $"I am a {Color} {Brand} {Model}";


    #region implement ISeed
    public csCar() {}
    public bool Seeded { get; set; } = false;
    public csCar Seed(csSeedGenerator _seeder)
    {
        Color = _seeder.FromEnum<enCarColor>();
        Brand = _seeder.FromEnum<enCarBrand>();
        Model = _seeder.FromEnum<enCarModel>();        
        return this;   
    }
    #endregion

    #region Implementation of IEquatable<T> interface
    public bool Equals(csCar other) => (this.Color, this.Brand, this.Model) == (other?.Color, other?.Brand, other?.Model);

    //Needed to implement as part of IEquatable
    public override bool Equals(object obj) => Equals(obj as csCar);
    public override int GetHashCode() =>(this.Color, this.Brand, this.Model).GetHashCode();
    #endregion
}