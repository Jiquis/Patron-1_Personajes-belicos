using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public class ThiefCaracter : Character
    {
        public ThiefCaracter() 
        {
            weaponBehavior = new NoWeapon();
        }
        public override void display()
        {
            Console.WriteLine("Soy un ladron y estoy esperando para tomar un arma");
        }
    }
}
