using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public class TrollCharacter : Character
    {
        public TrollCharacter() 
        {
            weaponBehavior = new Axe();
        }
        public override void display()
        {
            Console.WriteLine("Soy un troll y utilizo la hacha como arma");
        }
    }
}
