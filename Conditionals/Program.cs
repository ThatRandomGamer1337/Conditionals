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
        static int score;

        static void Main(string[] args)
        {

            Console.WriteLine("Conditionals");
            Console.WriteLine();
            Console.WriteLine();
         
            score = 0;
            health = 100;


            // - - - - - - - - - - - - - - - - -

            TakeDamage(0);
            ShowHUD();

            // Simulated Gameplay

            TakeDamage(10);
            ShowHUD();


            TakeDamage(20);
            ShowHUD();

            TakeDamage(30);
            ShowHUD();

            TakeDamage(20);
            ShowHUD();

            TakeDamage(50);
            ShowHUD();

            Console.ReadKey();


        }
        static void TakeDamage(int damage) // Code that plays when the player takes damage
        {
            Console.WriteLine("Player has taken " + damage + " damage!");

            health = health - damage;

            string status = ("PERFECTLY HEALTHY");

            if (health > 100)
            {
                health = 100;
                status = ("PERFECTLY HEALTHY");
            }

            if (health > 50 && health < 74)
            {
                status = ("HEALTHY");
            }

            if (health > 25 && health < 49)
            {
                status = ("INJURED");
            }

            if (health > 1 && health < 24)
            {
                status = ("CRITICALLY INJURED");
            }

            if (health < 0)
            {
                health = 0;
                status = ("DEAD");
            }
            Console.WriteLine("Current Health Status: " + status);


        }
        static void ShowHUD()
        {
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine();
            Console.WriteLine();
        }
    }     
}

