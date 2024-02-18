using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public class QueenCharacter : Character
    {
        public QueenCharacter() 
        {
            weaponBehavior = new BowAndArrow();
        }
        public override void display()
        {
            Console.WriteLine("Soy una reina y mi arma por defecto es el arco y flechas");
        }
    }
}
