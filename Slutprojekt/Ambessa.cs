namespace Slutprojekt;

public class Ambessa : Villain
{
    public Ambessa()
    {
        Namev = "Ambessa";
        vhp = 400;
        (vhp,kr)=Ambessauppgrade(vhp,kr); 
    }
    public static (int, int) Ambessauppgrade(int kr, int vhp)
    {
        kr = 500;
        Console.WriteLine("Välj vilken uppgradering");
        Console.WriteLine("1. uppgraderavhp gånger (5) 250kr");
        Console.WriteLine("2. uppgraderavhp gånger(10) 500kr");
        Console.WriteLine("3. uppgraderavhp gånger(3) 100kr");

        string vilken = "";
        int kostnad = 0;
        while (vilken != "1" && vilken != "2" && vilken != "3")
        {
            vilken = Console.ReadLine();

            Console.WriteLine("okej hur många");
            string antal = Console.ReadLine();
            int a = 0;
            int.TryParse(antal, out a);

            if (vilken == "1")
            {
                kostnad = a * 250;
                vhp *= 5;
            }
            else if (vilken == "2")
            {
                kostnad = a * 500;
                vhp *= 10;
            }
            else if (vilken == "3")
            {
                kostnad = a * 100;
                vhp *= 3;
            }

        }

        kr -= kostnad;

        return (kr, vhp);
    }
    
}
