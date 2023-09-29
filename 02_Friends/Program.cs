﻿using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Xml.Linq;
using Helpers;

namespace _02_Friends;

public enum enCarColor
{
    Brown, Red, Green, Burgundy
}
public enum enCarBrand
{
    Boxcar, Ford, Jaguar, Honda
}
public enum enCarModel
{
    Boxmodel, Mustang_GT, Golf, V70, XF, Civic
}
public class csCar
{

    private enCarColor _color;
    public enCarColor Color
    {
        get => _color;
      set => _color = value;
    }


    public enCarBrand Brand { get; init; }
    public enCarModel Model { get; set; }

    public string WhoAmI()
    {
        string _s = $"I am a {Color} {Brand} {Model}";
        return _s;
    }

    public csCar()
    {
        var rnd = new csSeedGenerator();

        //alternative to SeedGenerator
        var rnd1 = new Random();
        Model = (enCarModel)rnd1.Next((int)enCarModel.Boxmodel, (int)enCarModel.Civic + 1);


        Color = rnd.FromEnum<enCarColor>();
        Brand = rnd.FromEnum<enCarBrand>();
        Model = rnd.FromEnum<enCarModel>();
    }
}

public enum enFriendLevel
{
    Friend, ClassMate, Family, BestFriend
}
public class csFriend
{
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value == null || value == "")
            {
                throw new Exception("Name cannot be set to null");
            }
            _name = value;
        }
    }

    public string Email { get; set; }
    public enFriendLevel Level { get; set; }

    public csCar Car { get; set; }
        

    public override string ToString()
    {
        var sRet = $"{Name} is my {Level} and can be reached at {Email}.";
        if (Car != null)
        {
            sRet += $" The car is a {Car.Color} {Car.Brand} {Car.Model}";
        }
        return sRet;
    }

    public csFriend()
    {
        var rnd = new csSeedGenerator();
        string _firstName = rnd.FirstName;
        string _lastName = rnd.LastName;
        Name = $"{_firstName} {_lastName}";

        Email = rnd.Email(_firstName, _lastName);
        Level = rnd.FromEnum<enFriendLevel>();
        Car = new csCar();
    }
    public csFriend(string name, string email, enFriendLevel level)
    {
        Name = name;
        Email = email;
        Level = level;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Friends!");

        csFriend[] friends = new csFriend[10];
        for (int i = 0; i < 10; i++)
        {
            friends[i] = new csFriend();
        }

        foreach (var item in friends)
        {
            Console.WriteLine(item);
        }

        // var friend = new csFriend("Martin", "martin@gmail.com", enFriendLevel.ClassMate);
        // Console.WriteLine(friend.Name);

        /*
        #region how create a Random Name and Email address
        var rnd = new csSeedGenerator();

        //A random Name
        string _firstName = rnd.FirstName;
        string _lastName = rnd.LastName;
        Console.WriteLine($"{_firstName} {_lastName}");

        //A random email address
        Console.WriteLine(rnd.Email(_firstName, _lastName));
        #endregion
        */

        Console.ReadKey();
    }
}

//Exercises:
//1. Create a constructor to class csFriend that takes Name, Email, and Level as
//   Parameters and sets the corresponding properties.
//   Create an instance of csFriend(..) settign the properties with Arguments

//2. Create an empty constructor that sets all properties to random values
//   Create an instance of csFriend() setting the properties to random values.

//3. Create a method ToString() in csFriend that presents the instance of csFriend.
//   For example "Sam Baggins is my BestFriend and can be reached at sam.baggins@gmail.com"

//Advanced:
//4. Create an array of 10 random instances of csFriend and have them present themself

//5. Add a property, Car, of type csCar to csFriend class. Instantiate a csFriend
//   as a variable friend and give your friend a random car.

//6. Modify ToString() in csFriend to also present the friends car if it exists (not null)

//7. Modify the setter in Name so an Error is thrown if the new name is null or ""


// --- Gör tills 4 Oktober
// 8. Gör om construtor csFriend() så att den tar en parameter (csSeedGenerator _seeder).
//    Instantiera csSeedGeneratorn i Main() och modifiera koden så att den fungerar som innan.
//
// 10. Deklarera en Copy constructor.
//
// 11. Använd copy constructorn för att skapa en ny lista av 10 vänner som är en kopia
//     av ursprungslistan



