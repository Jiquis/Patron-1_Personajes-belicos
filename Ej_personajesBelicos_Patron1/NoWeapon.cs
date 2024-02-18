using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public class NoWeapon : WeaponBehavior
    {
        public void weapon()
        {
            Console.WriteLine("Este personaje no tiene ninguna arma actualmente");
        }
    }
}
