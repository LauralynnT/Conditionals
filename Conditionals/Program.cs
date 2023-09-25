using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static int health;
        static int lives;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine("------------");
            Console.WriteLine("");

            health = 100;
            lives = 3;

            ShowHUD("none");
            TakeDamage(10);
            ShowHUD("none");
            Weapon(0);
            ShowHUD("pistol");
            TakeDamage(25);
            ShowHUD("pistol");
            Heal(15);
            ShowHUD("pistol");
            Weapon(1);
            ShowHUD("shotgun");
            TakeDamage(25);
            ShowHUD("shotgun");
            TakeDamage(25);
            ShowHUD("shotgun");
            Weapon(2);
            ShowHUD("spreader");
            Heal(15);
            ShowHUD("spreader");
            TakeDamage(50);
            ShowHUD("spreader");


            Console.WriteLine("");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static void ShowHUD(string currentWeapon)
        {
            Console.WriteLine("\n");
            if (health <= 0)
            {
                Console.WriteLine("health: " + health + "\nStatus: dead");
            }
            else if (health > 0 && health <= 10)
            {
                Console.WriteLine("health: " + health + "\nStatus: imminent danger");
            }
            else if (health > 0 && health <= 50)
            {
                Console.WriteLine("health: " + health + "\nStatus: badly hurt");
            }
            else if (health > 50 && health <= 75)
            {
                Console.WriteLine("health: " + health + "\nStatus: hurt");
            }
            else if (health > 75 && health < 100)
            {
                Console.WriteLine("health: " + health + "\nStatus: healthy");
            }
            else if (health == 100)
            {
                Console.WriteLine("health: " + health + "\nStatus: perfect health");
            }
            Console.WriteLine("Current Weapon: " + currentWeapon);
            Console.WriteLine("lives: " + lives);
            Console.WriteLine("\n");
            Console.ReadKey(true);
        }
        static void TakeDamage(int damage)
        {
            Console.Write("player takes " + damage + " damage... \n");
            Console.ReadKey(true);
            health -= damage;
            if (health <= 0)
            {
                lives--;
                health = 100;
            }
        }
        static void Weapon(int weapon)
        {
            if (weapon == 0)
            {
                Console.WriteLine("player picks up weapon: Pistol");
            }
            else if (weapon == 1)
            {
                Console.WriteLine("player picks up weapon: Shotgun");
            }
            else if (weapon == 2)
            {
                Console.WriteLine("player picks up weapon: Spreader");
            }
            else if (weapon == 3)
            {
                Console.WriteLine("player picks up weapon: Laser");
            }
            else if (weapon == 4)
            {
                Console.WriteLine("player picks up weapon: Sniper");
            }
            else if (weapon == 5)
            {
                Console.WriteLine("player picks up weapon: BFG");
            }
            Console.ReadKey(true);
        }
        static void Heal(int healthPack)
        {
            Console.Write("player heals " + healthPack + "hp \n");
            health += healthPack;
            if (health >= 100)
            {
                health = 100;
            }
            Console.ReadKey(true);
        }
    }
}
