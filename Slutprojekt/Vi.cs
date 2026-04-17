namespace Slutprojekt;

public class Vi : Fightandhero
{
    public Vi()
    {
        Name = "Vi";
        weaponHp = 100;
        weapon = "Atlas gloves";
    }

    static (int, int) Viuppgrade(int kr, int weaponHp)
    {
        kr = 600;

        Console.WriteLine("1. uppgrade hp (5)");
        Console.WriteLine("2. uppgrade hp (10)");
        Console.WriteLine("3. uppgrade hp (3)");

        string uppgradering = "";
        int finalprice=0;

        while (uppgradering != "1" && uppgradering != "2" && uppgradering != "3")
        {
            uppgradering = Console.ReadLine(); 
            
            Console.WriteLine("Okej hur många ?");
        }

        
        return (kr, weaponHp); 
    }

}
