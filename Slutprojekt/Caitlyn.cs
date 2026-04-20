

namespace Slutprojekt;

public class Caitlyn : Fightandhero
{
    public Caitlyn()
    {
        Name = "Caitlyn";
        Weaponname = "Long Riffle";
        WeaponHp = 100;
    }

    static (int, int) CaitlynUppgrade(int Money, int Hp)
    {
        Console.WriteLine($"Du har så här{Money} mycke pengar");

        Console.WriteLine("1. uppgradera hp (5 gånger) 300kr ");
        Console.WriteLine("2. uppgradera hp (10 gånger) 600kr ");
        Console.WriteLine("3. uppgradera hp (3 gånger) 100kr ");

        string uppgrade = "";
        int finalprice = 0;

        // Loopen körs till något av kraven är uppfylld. 
        while (uppgrade != "1" && uppgrade != "2" && uppgrade != "3")
        {
            uppgrade = Console.ReadLine();

            // Antal uppgraderingar. 
            Console.WriteLine("Okej hur många ?");
            string howmuch = Console.ReadLine();
            int ke = 0;
            int.TryParse(howmuch, out ke);

            if (uppgrade == "1")
            {
                finalprice = ke * 300;
                Hp *= 5;
            }
            else if (uppgrade == "2")
            {
                finalprice = ke * 600;
                Hp *= 10;
            }
            else if (uppgrade == "3")
            {
                finalprice = ke * 100;
                Hp *= 3;
            }
            
            if (finalprice > Money)
            {
            Console.WriteLine($"du har inte råd med {ke} uppgraderingar");

            }
        }

        return (Money, Hp); 
    }

}
