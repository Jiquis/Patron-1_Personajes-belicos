using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public class KingCharacter : Character
    {
        public KingCharacter() 
        {
            weaponBehavior = new Sword();
        }
        public override void display()
        {
            Console.WriteLine("Soy el rey y uso por defecto una espada");   
        }
    }
}
