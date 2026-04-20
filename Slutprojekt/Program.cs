using Slutprojekt;

Fightandhero hero = new();
Villain villain = new();
List<string> HeroNames = [];
HeroNames.Add("VI");
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
        }
        else if (Hero == "Vi")
        {
            hero = new Vi();
            villain = new Ambessa();
        }
    }
    else
    {
        Console.WriteLine("Skriv ett namn från listan");
    }
}




Console.ReadLine(); 