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

        var friend = new csFriend("Martin", "martin@gmail.com", enFriendLevel.ClassMate);
        Console.WriteLine(friend.Name);

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



