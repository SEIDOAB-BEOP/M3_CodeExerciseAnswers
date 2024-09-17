using System.Runtime.InteropServices.Marshalling;
using Seido.Utilities.SeedGenerator;

namespace _01_Cars;

class Program
{
    public enum enCarColor { Brown, Red, Green, Burgundy}
    public enum enCarBrand { Boxcar, Ford, Jaguar, Honda}
    public enum enCarModel { Boxmodel, Mustang_GT, XF, Civic}
    
    public struct csCar
    {
        public enCarColor Color {get; init;}
        public enCarBrand Brand {get; set;}
        public enCarModel Model {get; set;}
        
        public override string ToString() => $"I am a {Color} {Brand} {Model}";

        public csCar(csSeedGenerator _seeder)
        {
            Color = _seeder.FromEnum<enCarColor>();
            Brand = _seeder.FromEnum<enCarBrand>();
            Model = _seeder.FromEnum<enCarModel>();           
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Class exploration with Cars!");

        var rnd = new csSeedGenerator();
        var c1 = new csCar(rnd) {Color = enCarColor.Green, Brand = enCarBrand.Ford};
        var c2 = new csCar(rnd) {Color = enCarColor.Green, Brand = enCarBrand.Ford};

        //c1.Color = enCarColor.Red;
        c1.Brand = enCarBrand.Honda;
        //c2.Color = enCarColor.Burgundy;
        c2.Brand = enCarBrand.Ford;   
        
        System.Console.WriteLine(c1);
        System.Console.WriteLine(c2);

        var cars = new List<csCar>();
        for (int i = 0; i < 10; i++)
        {
            cars.Add(new csCar(rnd){Color = enCarColor.Burgundy});
        }

        foreach (var item in cars)
        {
            System.Console.WriteLine(item);
        }


    }
}
    //Exercises:
    //1. Make class csCar public field Color a public property with getters and setters

    //2. Create two new public properties in class csCar, Brand, Model
    //   (of types enCarBrand and enCarModel)

    //3. Create a constructor csCar(csSeedGenerator _seeder) that sets Color, Brand and Model to Random values
    //   and returns the initialized instance

    //4. Override ToString() to present the instance, for example
    //   "I am a Red Ford Mustang_GT";

    //5. In Main(), create two variables, car1, car2 and instantiate from csCar
    //   - present car1 and car2

    //6. Modify the properties Color, Brand and Model so that only Color can change
    //   when the instance is created, not afterwards

    //7. Modify the properties of Brand and Model so they can also be set during
    //   Object initialization, i.e.  new Car(){ Model = ..., Brand = ...}

    //8. Create a List<csCar> cars of 10 cars, all of Color Burgundy, but otherwise random

    //9. Change class Car to struct Car and run the program again.

