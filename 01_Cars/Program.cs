using System.Reflection;
using Helpers;

namespace _01_Cars;

class Program
{
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
    class csCar
    {
        public enCarColor Color { get; set; }
        public enCarBrand Brand { get; set; }
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
            Model =  (enCarModel) rnd1.Next((int)enCarModel.Boxmodel, (int)enCarModel.Civic + 1);


            Color = rnd.FromEnum<enCarColor>();
            Brand = rnd.FromEnum<enCarBrand>();
            Model = rnd.FromEnum<enCarModel>();
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Class exploration with Cars!");

        csCar car1 = new csCar();
        string s = car1.WhoAmI();
        Console.WriteLine(s);

        csCar car2 = new csCar();
        Console.WriteLine(car2.WhoAmI());

        /*
        #region how To use the seed generator
        var rnd = new csSeedGenerator();

        //A random enCarColor
        enCarColor rndColor = rnd.FromEnum<enCarColor>();
        Console.WriteLine(rndColor.ToString());

        //A random enCarBrand
        Console.WriteLine(rnd.FromEnum<enCarBrand>());

        //A random enCarModel
        Console.WriteLine(rnd.FromEnum<enCarModel>());
        #endregion
        */

    }

    //Exercises:
    //1. Make class csCar public field Color a public property with getters and setters

    //2. Create two new public properties in class csCar, Brand, Model
    //   (of types enCarBrand and enCarModel)

    //3. Create an empty class constructor to csCar that sets Color, Brand and Model to
    //   Random values

    //4. Create a method public method WhoAmI() that presents for example
    //   "I am a Red Ford Mustang_GT";

    //5. In Main(), create two variables, car1, car2 and instantiate from csCar
    //   - printout WhoAmI of car1 and car2

    //Advanced:
    //6. Modify the properties Color, Brand and Model so that only Color can change
    //   once an instance of Car has been created

    //7. Modify the properties of Brand and Model so they can also be set during
    //   Object initialization, i.e.  new Car(){ Model = ..., Brand = ...}

    //8. Create an array of 1000 cars, all of Color Burgundy.

    //9. Change class Car to struct Car and run the program again.
}

