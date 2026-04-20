namespace Slutprojekt;
// den andra skurken; 
public class Ambessa : Villain
{
    public Ambessa()
    {
        VillainName = "Ambessa";
        VillainHp = 400;
        (VillainHp, Money) = Ambessauppgrade(Money, VillainHp); 
    }
    public static (int, int) Ambessauppgrade(int money, int Hp)
    {
        Console.WriteLine($" Du har så här {money} mycket pengar");

        Console.WriteLine("Välj vilken uppgradering");
        Console.WriteLine("1. uppgraderavhp gånger (5) 250kr");
        Console.WriteLine("2. uppgraderavhp gånger(10) 500kr");
        Console.WriteLine("3. uppgraderavhp gånger(3) 100kr");

        string Whichppgrade = "";
        int endprice = 0; 

        while (Whichppgrade != "1" && Whichppgrade != "2" && Whichppgrade != "3")
        {
             Whichppgrade= Console.ReadLine();

            Console.WriteLine("okej hur många");
            string antal = Console.ReadLine();
            int a = 0;
            int.TryParse(antal, out a);

            if (Whichppgrade == "1")
            {
                endprice = a * 250;
                Hp *= 5;
            }
            else if (Whichppgrade == "2")
            {
                endprice = a * 500;
                Hp *= 10;
            }
            else if (Whichppgrade == "3")
            {
                endprice = a * 100;
                Hp *= 3;
            }

        }

        money -= endprice; 

        return (money, Hp);
    }
    
}
