using System.Data;
using Slutprojekt;

Fightandhero hero = new();
Villain villain = new();
List<string> HeroNames = [];
HeroNames.Add("Vi");
HeroNames.Add("Caitlyn");
foreach (var item in HeroNames)
{
    Console.WriteLine(item);
}

Console.Write(""); 

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