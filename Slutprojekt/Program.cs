using System.Data;
using Slutprojekt;
// Lista på vilken hero du kan få 
Fightandhero hero = new();
Villain villain = new();
List<string> HeroNames = [];


HeroNames.Add("Vi");
HeroNames.Add("Caitlyn");
List<string> Villains = [];
Villains.Add("Ambessa"); 
Villains.Add("Jinx");

foreach (var item in HeroNames)
{
    Console.WriteLine(item); 
}
foreach (var item in Villains)
{
    Console.WriteLine(item); 
}

bool Flamingo = false;
string Hero = "";
string Villan = ""; 
while (!Flamingo)
{
    Hero = Console.ReadLine();
    Villan = Console.ReadLine();
    if (HeroNames.Contains(Hero)&& Villains.Contains(Villan))
    {
        Console.WriteLine($"Du är {Hero}");
        if (Hero == "Caitlyn")
        {
            hero = new Caitlyn();
            villain = new Jinx();
            Flamingo = true;
        }
        else if (Hero == "Vi"&& Villan== "Jinx")
        {
            hero = new Vi();
            villain = new Ambessa();
            Flamingo = true;
        }
    }
    else
    {
        Console.WriteLine("Skriv ett namn från listan");
    }
}

hero.Attack(villain);
hero.Upgrade();

villain.Upgrade();

hero.saveattack(villain); 






Console.ReadLine(); 