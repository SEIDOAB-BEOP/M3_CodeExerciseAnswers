using System;
using Seido.Utilities.SeedGenerator;
using Models;


Console.WriteLine("Hello, Inheritance!");

Console.WriteLine("\nShapes");
csTriangle t1 = new csTriangle() { Height = 100, Width = 200 };
csTriangle t2 = new csTriangle() { Height = 100, Width = 200 };
System.Console.WriteLine(t1);
System.Console.WriteLine(t1 == t2);

csRectangle r1 = new csRectangle() { Height = 100, Width = 200 };
csRectangle r2 = new csRectangle() { Height = 100, Width = 200 };
System.Console.WriteLine(r1 == r2);

csSquare sq1 = new csSquare() { Height = 25};
csSquare sq2 = new csSquare() { Height = 25};
System.Console.WriteLine(sq1 == sq2);

csSquare sq3 = new csSquare() { Width = 50};
System.Console.WriteLine(sq3);

csCircle ci1 = new csCircle() { Radius = 50};
csCircle ci2 = new csCircle() { Radius = 50};
System.Console.WriteLine(ci1 == ci2);
System.Console.WriteLine(ci1);

Console.WriteLine("\n\nChefs");
var ich = new csItalianChef(){Name = "Mauro", Age= 35, FavoriteDish = "Pasta"};
var gch = new csGermanChef(){Name = "Franz", Age=40, FavoriteDish="Wurst"};
var fch = new csFrenchChef(){Name = "Nicolas", Age= 25, FavoriteDish="Escargot"};

System.Console.WriteLine(ich);
System.Console.WriteLine(gch);
System.Console.WriteLine(fch);


System.Console.WriteLine("\nList of chefs");
List<csChef> chefs = new List<csChef>();
chefs.Add(fch);
chefs.Add(gch);
chefs.Add(ich);
foreach (var item in chefs)
{
   System.Console.WriteLine(item);
}
for (int i = 0; i < chefs.Count; i++)
{
   System.Console.WriteLine(chefs[i]);
}

System.Console.WriteLine("\n\nList of Shapes");
List<csShape> shapes = new List<csShape>();
shapes.Add(r1);
shapes.Add(r2);
shapes.Add(t1);
shapes.Add(t2);
shapes.Add(sq1);
shapes.Add(sq2);
shapes.Add(ci1);
shapes.Add(ci2);
foreach (var item in shapes)
{
   System.Console.WriteLine($"{item.GetType()} - {item.Width}  {item.Height} {item.Area} {((item is csCircle ci) ?ci.Radius :null)}");
    if (item is csCircle ci4)
    {
       System.Console.WriteLine($"Radius: {ci4.Radius}");
    }
}

/*Exercise:
With Models/csShapes.cs:
1. Implement operator overload on == and != in base class csShapes. 
2. Instantiate a two of each Rectangles, Triangles, Squares with same Height and Width and test the operator ==
3. Implement a Circle as a derivative of Square. Have the Circle present itself and its area. Area Radius*Radius*Math.Pi
   Hint: Circle can have a property Radius that gets and sets the parents Square's property Width

With Models/csChef.cs
1. Create a French, Italian, German chef that has it's own name, age, and favorite dish. Have them present themself
2. Create a List<csChef> and add the three chefs to the list. 
   Create a method that Loop through the list and present each chef.

Polymorfism
1. Give each chef it's own Greeting. Experiement with new, and virtual/override and present list of chef. 
   what happend, explain.
2. Make a list of Shapes, and add an instance of each shapehave to the list. Haveeach shape present itself with the right Area.


*/