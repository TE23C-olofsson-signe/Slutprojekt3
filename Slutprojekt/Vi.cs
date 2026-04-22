using System.Threading.Tasks;

namespace Slutprojekt;

public class Vi : Fightandhero
{
    public Vi()
    {
        Name = "Vi";
        WeaponHp =90;
        Weaponname = "Atlas gloves";
        SaveName= "Littleman"; 
    }

    // köp av Hp uppgradering. 
    public override void Upgrade()
    {
        Console.WriteLine($"Du har så här{Money} mycke pengar ");

        Console.WriteLine("1. uppgradera hp (2) 300kr");
        Console.WriteLine("2. uppgradera hp (10) 600kr");
        Console.WriteLine("3. uppgradera hp (5) 100kr");

        string uppgrade = "";
        int finalprice = 0;

        // Loopen körs till någon  av kraven uppfylls: 
        while (uppgrade != "1" && uppgrade != "2" && uppgrade != "3")
        {
            uppgrade = Console.ReadLine();

            // Antal uppgraderingar. 
            Console.WriteLine("Okej hur många ?");
            string howmany = Console.ReadLine();
            int p = 0;
            int.TryParse(howmany, out p);



            if (uppgrade == "1")
            {
                finalprice = p * 300;
                WeaponHp *= 2;
            }
            else if (uppgrade == "2")
            {
                finalprice = p * 600;
                WeaponHp *= 10;
            }
            else if (uppgrade == "3")
            {
                finalprice = p * 100;
                WeaponHp *= 5;
            }

            if (finalprice > Money)
            {
                Console.WriteLine($"du har inte råd med {p} uppgraderingar");
            }

        }

        Money -= finalprice; 
        
    }

}
