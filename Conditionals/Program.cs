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
        static int lives = 3;
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine("------------");
            Console.WriteLine("");

            health = 100;

            ShowHUD();
            TakeDamage(10);
            ShowHUD();
            TakeDamage(25);
            ShowHUD();
            TakeDamage(10);
            ShowHUD();
            TakeDamage(15);
            ShowHUD();
            TakeDamage(5);
            ShowHUD();
            TakeDamage(20);
            ShowHUD();
            TakeDamage(15);
            ShowHUD();
            TakeDamage(25);
            ShowHUD();
            TakeDamage(10);
            ShowHUD();
            TakeDamage(10);
            ShowHUD();
            TakeDamage(5);
            ShowHUD();
            TakeDamage(15);
            ShowHUD();

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static void ShowHUD()
        {
            Console.WriteLine("health: " + health);
            
            Console.WriteLine("lives: " + lives);
        }
        static void TakeDamage(int damage)
        {
            Console.Write("Player about to take " + damage + " damage... \n");
            Console.ReadKey(true);
            health -= damage;
            if (health <= 0)
            {
                lives--;
                health = 100;
            }
        }
    }
}
