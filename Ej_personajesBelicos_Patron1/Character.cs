using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public abstract class Character
    {
        protected WeaponBehavior weaponBehavior;
        public Character() { }
        public abstract void display();
        public void performWeapon()
        {
            weaponBehavior.weapon();
        }
        public void critic_dmg(Random x)
        {
            int crit = x.Next(0,4);
            switch (crit) 
            {
                case 0:
                    Console.WriteLine("El ataque no surgio efecto en el enemigo");
                    break;
                case 1:
                    Console.WriteLine("El ataque hizo poco efecto en el enemigo");
                    break;
                case 2:
                    Console.WriteLine("El ataque hizo efecto neutro en el enemigo");
                    break;
                case 3:
                    Console.WriteLine("El ataque dio en un punto vital en el enemigo");
                    break;
            }
        }
        public void setWeaponBehavior(WeaponBehavior wb)
        {
            weaponBehavior = wb;
        }
    }
}
