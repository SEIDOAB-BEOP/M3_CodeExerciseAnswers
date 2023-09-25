using Helpers;

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
        set => _name = value;
    }

    public string Email { get; set; }
    public enFriendLevel Level { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Friends!");

        #region how create a Random Name and Email address
        var rnd = new csSeedGenerator();

        //A random Name
        string _firstName = rnd.FirstName;
        string _lastName = rnd.LastName;
        Console.WriteLine($"{_firstName} {_lastName}");

        //A random email address
        Console.WriteLine(rnd.Email(_firstName, _lastName));
        #endregion
    }
}

//Exercises:
//1. Create a constructor to class csFriend that takes Name, Email, and Level as
//   Parameters and sets the corresponding properties.
//   Create an instance of csFriend(..) settign the properties with Arguments
//2. Create an empty constructor that sets all properties to random values
//   Create an instance of csFriend() setting the properties to random values.
//3. Modify the setter in Name so an Error is thrown if "" null is begin
//   set as Name

//4. Create a method ToString() in csFriend that presents the instance of csFriend.
//   For example "Sam Baggins is my BestFriend and can be reached at sam.baggins@gmail.com"
//5. Create an array of 10 random instances of csFriend and have them present themself

//6. Add a csCar as a property, Car, to csFriend class. Instantiate a csFriend
//   as a variable friend and give your friend a car.



