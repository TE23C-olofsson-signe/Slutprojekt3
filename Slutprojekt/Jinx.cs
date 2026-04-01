
using System.Data;

namespace Slutprojekt;

public class Jinx:Villain
{
    public Jinx()
    {
        Namev = "Jinx";
        vhp = 4000;
        
      (vhp, kr) = UppgradeJinx(kr,vhp); 
       
        
    }
    public  static (int,int)UppgradeJinx(int kr, int vhp)
        {

            return (kr, vhp);
        }
        
}
