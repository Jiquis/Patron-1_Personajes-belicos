using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public class VillagerCharacter : Character
    {
        public VillagerCharacter() 
        {
            weaponBehavior = new NoWeapon();
        }
        public override void display()
        {
            Console.WriteLine("Soy un aldeano que no está entrenado para el combate");
        }
    }
}
