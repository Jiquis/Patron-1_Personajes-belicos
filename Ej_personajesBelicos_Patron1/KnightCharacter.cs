using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public class KnightCharacter : Character
    {
        public KnightCharacter() 
        {
            weaponBehavior = new Knife();
        }
        public override void display()
        {
            Console.WriteLine("Soy un caballero y utilizo el cuchillo como arma");
        }
    }
}
