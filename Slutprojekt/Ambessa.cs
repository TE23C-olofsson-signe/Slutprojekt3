namespace Slutprojekt;
// den andra skurken; 
public class Ambessa : Villain
{
    public Ambessa()
    {
        villainname = "Ambessa";
        villainhp = 400;
        (villainhp, money) = Ambessauppgrade(money, villainhp); 
    }
    public static (int, int) Ambessauppgrade(int money, int Hp)
    {
        money = 500;
        Console.WriteLine("Välj vilken uppgradering");
        Console.WriteLine("1. uppgraderavhp gånger (5) 250kr");
        Console.WriteLine("2. uppgraderavhp gånger(10) 500kr");
        Console.WriteLine("3. uppgraderavhp gånger(3) 100kr");

        string vilken = "";
        int endprice = 0; 

        while (vilken != "1" && vilken != "2" && vilken != "3")
        {
            vilken = Console.ReadLine();

            Console.WriteLine("okej hur många");
            string antal = Console.ReadLine();
            int a = 0;
            int.TryParse(antal, out a);

            if (vilken == "1")
            {
                endprice = a * 250;
                Hp *= 5;
            }
            else if (vilken == "2")
            {
                endprice = a * 500;
                Hp *= 10;
            }
            else if (vilken == "3")
            {
                endprice = a * 100;
                Hp *= 3;
            }

        }

        money -= endprice; 

        return (money, Hp);
    }
    
}
