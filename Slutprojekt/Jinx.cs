namespace Slutprojekt;

public class Jinx:Villain
{ // koden för skurken jinx  
    public Jinx()
    {
        Namev = "Jinx";
        vhp = 400;
        (vhp, kr) = Jinxuppgrade(kr, vhp); 
      
    }
        // uppgraderings metoden för Jinx Hit points
       public static (int, int) Jinxuppgrade(int kr, int vhp)
    {
        kr = 500;
        Console.WriteLine("Välj vilken uppgradering");
        Console.WriteLine("1. uppgradera hp gånger (5) 250kr");
        Console.WriteLine("2. uppgraderavhp gånger(10) 500kr");
        Console.WriteLine("3. uppgraderavhp gånger(3) 100kr");

        string vilkenuppgradern = "";
        int kostnad = 0;
        while (vilkenuppgradern != "1" && vilkenuppgradern != "2" && vilkenuppgradern != "3")
        {
            vilkenuppgradern = Console.ReadLine();

            Console.WriteLine("okej hur många");
            string antal = Console.ReadLine();
            int a = 0;
            int.TryParse(antal, out a);

            if (vilkenuppgradern == "1")
            {
                kostnad = a * 250;
                vhp *= 5;
            }
            else if (vilkenuppgradern == "2")
            {
                kostnad = a * 500;
                vhp *= 10;
            }
            else if (vilkenuppgradern == "3")
            {
                kostnad = a * 100;
                vhp *= 3;
            }

        }

        kr -= kostnad;

        return (kr, vhp);
    }
        
}
