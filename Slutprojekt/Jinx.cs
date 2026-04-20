namespace Slutprojekt;

public class Jinx:Villain
{ // koden för skurken jinx  
    public Jinx()
    {
        VillainName = "Jinx";
        VillainHp = 500;
    }

    public override void Upgrade(int kr, int hp)
    {
        Console.WriteLine("Välj vilken uppgradering");
        Console.WriteLine("1. uppgradera hp gånger (2) 250kr");
        Console.WriteLine("2. uppgraderavhp gånger(10) 500kr");
        Console.WriteLine("3. uppgraderavhp gånger(5) 100kr");

        string wichuppgrade = "";
        int kostnad = 0;
        while (wichuppgrade != "1" && wichuppgrade != "2" && wichuppgrade != "3")
        {
            wichuppgrade = Console.ReadLine();

            // Antal uppgraderingar. 
            Console.WriteLine("okej hur många");
            string antal = Console.ReadLine();
            int a = 0;
            int.TryParse(antal, out a);

            if (wichuppgrade == "1")
            {
                kostnad = a * 250;
                hp *= 5;
            }
            else if (wichuppgrade == "2")
            {
                kostnad = a * 500;
                hp *= 10;
            }
            else if (wichuppgrade == "3")
            {
                kostnad = a * 100;
                hp *= 3;
            }

        }

        kr -= kostnad;

      
    }
        
}
