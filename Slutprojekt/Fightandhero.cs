using System;

namespace Slutprojekt;

    // Klassen för Hjälten och Bråket 
public class Fightandhero
{
    // Stringar och intar som alla kan ändra på  och 
    public string Name; 
    public string weapon; 
    public int weaponHp; 
    protected string SaveName;
    protected int kr = 500; 

    // Koden för attacken kan ändras i subklasser. 
    protected void attack(Villain target)
    {
        Console.WriteLine($"{Name} attackerar {target.Namev} Med sitt vapen{weapon}");

        while (target.vhp > 0)
        {
            Console.WriteLine($"\n------=====Slå {target.Namev}=====------");
            Console.WriteLine($"{Name}:{weapon}:{weaponHp}:{target.Namev}:{target.vhp}\n");

            int weapondamage = weaponHp;
            target.vhp -= weapondamage;
            target.vhp = Math.Max(0, target.vhp);

            Console.WriteLine($"{weapon} gör {weapondamage} på {target.vhp}");
            Console.ReadKey();
        }
        Console.WriteLine($"Yay du slog{target.Namev}");
    }
    //kode för saveattack. 
    protected void saveattack(Villain target)
    {
        Console.WriteLine($"{Name} attackerar {target.Namev} Med sitt vapen{weapon}");
        while (target.vhp>0)
        {
            Console.WriteLine($"\n------=====Rädda {SaveName}=====------");
            Console.WriteLine($"{Name}:{weapon}:{weaponHp}:{target.Namev}:{target.vhp}\n");

            int weaponDamage= weaponHp; 
            target.vhp-= weaponDamage;
            target.vhp = Math.Max(0, target.vhp); 

            Console.WriteLine($"{weapon} gör {weaponDamage} på {target.vhp}");
            Console.ReadKey();
        }
        Console.WriteLine($"YAy du räddade{SaveName}");
    }
}
