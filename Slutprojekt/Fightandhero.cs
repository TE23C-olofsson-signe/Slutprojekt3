

namespace Slutprojekt;

// Klassen för Hjälten och Bråket 
public class Fightandhero
{
    // Stringar och intar som alla kan ändra på  och 
    public string Name;
    public string Weaponname;
    public int WeaponHp;
    protected string SaveName;
    public int Money;


    // Koden för attacken kan ändras i subklasser. 
    public void Attack(Villain target)
    {
        Console.WriteLine($"{Name} attackerar {target.VillainName} Med sitt vapen{Weaponname}");

        while (target.VillainHp > 0)
        {
            Console.WriteLine($"\n------=====Slå {target.VillainName}=====------");
            Console.WriteLine($"{Name}:{Weaponname}:{WeaponHp}:{target.VillainName}:{target.VillainHp}\n");

            int weapondamage = WeaponHp;
            target.VillainHp -= weapondamage;
            target.VillainHp = Math.Max(0, target.VillainHp);

            Console.WriteLine($"{Weaponname} gör {weapondamage} på {target.VillainHp}");
            Console.ReadKey();
        }
        Console.WriteLine($"Yay du slog{target.VillainName}");
    }
    //kode för saveattack. 
    public void saveattack(Villain target)
    {
        Console.WriteLine($"{Name} attackerar {target.VillainName} Med sitt vapen{Weaponname}");
        while (target.VillainHp > 0)
        {
            Console.WriteLine($"\n------=====Rädda {SaveName}=====------");
            Console.WriteLine($"{Name}:{Weaponname}:{WeaponHp}:{target.VillainName}:{target.VillainHp}\n");

            int weaponDamage = WeaponHp;
            target.VillainHp -= weaponDamage;
            target.VillainHp = Math.Max(0, target.VillainHp);

            Console.WriteLine($"{Weaponname} gör {weaponDamage} på {target.VillainHp}");
            Console.ReadKey();
        }
        Console.WriteLine($"YAy du räddade{SaveName}");
    }

    public virtual void Upgrade()
    {
    
    }
}
