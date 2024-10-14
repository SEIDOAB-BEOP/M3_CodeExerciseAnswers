using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello Seeder!");
var _seeder = new csSeedGenerator();

var cars = _seeder.ItemsToList<csCar>(100);
var ucars = _seeder.UniqueItemsToList<csCar>(100);


var friends = _seeder.ItemsToList<csFriend>(100);
var ufriends = _seeder.UniqueItemsToList<csFriend>(100);

var pearls = _seeder.ItemsToList<csPearl>(100);
var upearls = _seeder.UniqueItemsToList<csPearl>(100);

var wines = _seeder.ItemsToList<csPearl>(100);
var uwines = _seeder.UniqueItemsToList<csPearl>(100);


/* Exercises
1. Explore csSeedGenerator interface ISeed<T>. 
   - What does it require of a class that implements it?
2. Implement ISeed on csCar, csFriend, csPearl, csWine, e.g. ISeed<csCar> ... etc
3. Explore csSeedGenerator public List<TItem> ItemsToList<TItem>(int NrOfItems)
   - What interface is required to be implemented by a class to use ItemsToList?
   - Use ItemsToList to generate a list of 100 instances of csCar, csFriend, csPearl and csWine

4. Explore csSeedGenerator public List<TItem> UniqueItemsToList<TItem>(int tryNrOfItems, List<TItem> appendToUnique = null)
   - What interfaces are required to be implemented by a class to use UniqueItemsToList?
   - Use UniqueItemsToList to generate a list of unique 100 instances of csCar, csFriend, csPearl and csWine
 
*/
