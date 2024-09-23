using Seido.Utilities.SeedGenerator;

namespace _02_Friends;

public enum enFriendLevel
{
    Friend, ClassMate, Family, BestFriend
}
public class csFriend
{
    
    private string _name;
    public string Name
    {
        get => _name;
        set{
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(Name));
            
            _name = value;
        }
    }

    public string Email { get; set; }
    public enFriendLevel Level { get; set; }

    public csCar Car { get; set; } = null;

    public override string ToString() {
        string _sRet = $"{Name} is my {Level} and can be reached at {Email}";
        if (Car == null)
         {
            _sRet += "\n   Has no car";
         }
         else
         {
            _sRet += $"\n   {Car.ToString()}";
         }
         return _sRet;
    }


    public csFriend(string Name, string Email, enFriendLevel Level)
    {
        this.Name = Name;
        this.Email = Email;
        this.Level = Level;
    }
    public csFriend(string Name, string Email, enFriendLevel Level, 
    enCarColor carColor, enCarBrand carBrand, enCarModel carModel) : this(Name, Email, Level)
    {
        //this.Name = Name;
        //this.Email = Email;
        //this.Level = Level;

        this.Car = new csCar(){ Color = carColor, Brand = carBrand, Model = carModel };
    }
    public csFriend(csSeedGenerator _seed)
    {
        string _firstName = _seed.FirstName;
        string _lastName = _seed.LastName;
        this.Name = $"{_firstName} {_lastName}";
        this.Email = _seed.Email(_firstName, _lastName);
        this.Level = _seed.FromEnum<enFriendLevel>();
        this.Car = new csCar(_seed);
    }
}

public enum enCarColor { Brown, Red, Green, Burgundy}
public enum enCarBrand { Boxcar, Ford, Jaguar, Honda}
public enum enCarModel { Boxmodel, Mustang_GT, XF, Civic}
    
public class csCar
{
    public enCarColor Color {get; init;}
    public enCarBrand Brand {get; set;}
    public enCarModel Model {get; set;}
    
    public override string ToString() => $"Owns a {Color} {Brand} {Model}";

    public csCar() {}
    public csCar(csSeedGenerator _seeder)
    {
        Color = _seeder.FromEnum<enCarColor>();
        Brand = _seeder.FromEnum<enCarBrand>();
        Model = _seeder.FromEnum<enCarModel>();           
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Friends!");

        var rnd = new csSeedGenerator();
        var f1 = new csFriend("Joar Monell", "jm@gmail.com", enFriendLevel.ClassMate);
        var f2 = new csFriend("Ashok Tamang", "at@gmail.com", enFriendLevel.ClassMate,
            enCarColor.Burgundy, enCarBrand.Jaguar, enCarModel.XF );
        var f3 = new csFriend(rnd);

        System.Console.WriteLine(f1.ToString());
        System.Console.WriteLine(f2);
        System.Console.WriteLine(f3);

        var friends = new List<csFriend>();
        friends.Add(f1);
        friends.Add(f2);
        for (int i = 0; i < 8; i++)
        {
            var f = new csFriend(rnd);
            friends.Add(f);
        }
        foreach (var item in friends)
        {
            System.Console.WriteLine(item);
        }

        /*
        #region how create a Random Name and Email address
        var rnd = new csSeedGenerator();

        //A random Name
        string _firstName = rnd.FirstName;
        string _lastName = rnd.LastName;
        string Name = $"{_firstName} {_lastName}";
        Console.WriteLine(Name);

        //A random email address
        Console.WriteLine(rnd.Email(_firstName, _lastName));
        #endregion
        */
    }
}

//Exercises:
//1. Create a constructor to class csFriend that takes Name, Email, and Level as
//   Parameters and sets the corresponding properties.
//   Create an instance of csFriend(..) settign the properties with Arguments

//2. Create a constructor csFriend(csSeedGenerator _seeder) that sets all properties to random values and
//   returns the initialized instance

//3. Override method ToString() in csFriend to presents the instance of csFriend.
//   For example "Sam Baggins is my BestFriend and can be reached at sam.baggins@gmail.com"

//4. Create a List<csFriend> friends, with 10 random instances of csFriend and have them present themself

//Advanced:
//5. Add a property, Car, of type csCar to csFriend class. Instantiate a csFriend
//   as a variable friend and give your friend a random car.

//6. Modify ToString() in csFriend to also present the friends car if it exists (not null)

//7. Modify the setter in Name so an Error is thrown if the new name is null or ""

//8. Declare a Copy constructor in csFriend and csCar

//9. Use the copy constructor to create a copy of the list friends. Verify that it is a copy.

