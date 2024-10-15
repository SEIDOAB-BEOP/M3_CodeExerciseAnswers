using Seido.Utilities.SeedGenerator;

namespace Models;

public enum enFriendLevel { Friend, ClassMate, Family, BestFriend }
public class csFriend : ISeed<csFriend>, IEquatable<csFriend>
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

    public override string ToString() => $"{Name} is my {Level} and can be reached at {Email}";

    public csFriend(string Name, string Email, enFriendLevel Level)
    {
        this.Name = Name;
        this.Email = Email;
        this.Level = Level;
    }

    #region implement ISeed
    public csFriend(){}
    public bool Seeded { get; set; } = false;

    public csFriend Seed(csSeedGenerator _seed)
    {
        string _firstName = _seed.FirstName;
        string _lastName = _seed.LastName;
        this.Name = $"{_firstName} {_lastName}";
        this.Email = _seed.Email(_firstName, _lastName);
        this.Level = _seed.FromEnum<enFriendLevel>();
        return this;
    }
    #endregion

    #region Implementation of IEquatable<T> interface
    public bool Equals(csFriend other) => (this.Name, this.Email, this.Level) == (other?.Name, other?.Email, other?.Level);

    //Needed to implement as part of IEquatable
    public override bool Equals(object obj) => Equals(obj as csFriend);
    public override int GetHashCode() =>(this.Name, this.Email, this.Level).GetHashCode();
    #endregion

}