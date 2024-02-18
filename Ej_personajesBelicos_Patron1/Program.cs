using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_personajesBelicos_Patron1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            do
            {
                try
                {
                    int y;
                    // creacion de personajes
                    Character king = new KingCharacter();
                    Character queen = new QueenCharacter();
                    Character knight = new KnightCharacter();
                    Character troll = new TrollCharacter();
                    Character thief = new ThiefCaracter();
                    Character villager = new VillagerCharacter();
                    //daño por ataque
                    Random x = new Random();
                    // KING
                    Console.WriteLine("ATAQUES DEL REY");
                    king.display();
                    king.performWeapon();
                    king.critic_dmg(x);
                    // QUEEN
                    Console.WriteLine("\nATAQUES DE LA REINA");
                    queen.display();
                    queen.performWeapon();
                    queen.critic_dmg(x);
                    // KNIGHT
                    Console.WriteLine("\nATAQUES DEL CABALLERO");
                    knight.display();
                    knight.performWeapon();
                    knight.critic_dmg(x);
                    // TROLL
                    Console.WriteLine("\nATAQUES DEL TROLL");
                    troll.display();
                    troll.performWeapon();
                    troll.critic_dmg(x);
                    // THIEF
                    Console.WriteLine("\nATAQUES DEL LADRON");
                    thief.display();
                    thief.performWeapon();
                    Console.Write("\nPosibles armas que puede tomar el ladron \n1)Knife\n2)Bow and arrows\n3)Sword\n4)Axe\nElige el arma que deseas tomar: ");
                    y = int.Parse(Console.ReadLine());
                    switch (y)
                    {
                        case 1:
                            thief.setWeaponBehavior(new Knife());
                            break;
                        case 2:
                            thief.setWeaponBehavior(new BowAndArrow());
                            break;
                        case 3:
                            thief.setWeaponBehavior(new Sword());
                            break;
                        case 4:
                            thief.setWeaponBehavior(new Axe());
                            break;
                        default:
                            throw new ArgumentException("Opción no válida. Por favor, selecciona una opción válida del menú.");
                    }
                    salir = true;
                    Console.WriteLine("\nEl ladron lanza un ataque con la arma robada");
                    thief.performWeapon();
                    thief.critic_dmg(x);
                    // ALDEANO
                    Console.WriteLine("\nATAQUES DEL ALDEANO");
                    villager.display();
                    villager.performWeapon();
                    Console.ReadKey();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            } while (!salir);
        }
    }
}
