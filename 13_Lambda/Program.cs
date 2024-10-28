// See https://aka.ms/new-console-template for more information
using System.Drawing;
using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello, World!");
var _seeder = new csSeedGenerator();


AlarmResponseDelegate alarm = priority => (priority) switch
    {
        1 => "Company1 Critical Level",
        2 => "Company1 Moderate Level",
        3 => "Company1 Easy Level",
        _ => "Comapny1 Unknown Level"
    };
 
string resp = alarm(2);
System.Console.WriteLine(resp);

List<csPearl> pearls = new List<csPearl>();
for (int i = 0; i < 100; i++)
{
    pearls.Add(new csPearl(_seeder));
}    

var alist =  pearls.Where ((csPearl p)  => {
    
    if (p.Color == enPearlColor.White && p.Size > 20) return true;
    if (p.Color == enPearlColor.Black && p.Size < 10) return true;
    return false;
})
    .OrderBy (p => p.Size)
    .ToList();

foreach (var item in alist)
{
    System.Console.WriteLine(item);   
}







delegate string AlarmResponseDelegate(int priority);