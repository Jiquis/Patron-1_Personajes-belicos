﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    public class Sword : WeaponBehavior
    {
        public void weapon()
        {
            Console.WriteLine("*Atravesado por una espada*");
        }
    }
}
