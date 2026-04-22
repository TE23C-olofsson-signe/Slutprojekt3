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

if (HeroNames.Count==Villains.Count)
{
    for (int i = 0; i < HeroNames.Count; i++)
    {
        Console.WriteLine($"{HeroNames.Count}:{Villains.Count}");
    }
}

bool Flamingo = false;
string Hero = "";
while (!Flamingo)
{
    Hero = Console.ReadLine();
    if (HeroNames.Contains(Hero))
    {
        Console.WriteLine($"Du är {Hero}");
        if (Hero == "Caitlyn")
        {
            hero = new Caitlyn();
            villain = new Jinx();
            Flamingo = true;
        }
        else if (Hero == "Vi")
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