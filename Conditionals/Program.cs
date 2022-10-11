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

            int enemyPoints;
            int doublePoints;

            score = 0;
            health = 100;
            enemyPoints = 25;
            doublePoints = 2;


            // - - - - - - - - - - - - - - - - -

            selectedWeapon(1);
            TakeDamage(0);
            ShowHUD();

            // Simulated Gameplay

            selectedWeapon(1);
            scoreCounting(enemyPoints, 1);
            TakeDamage(10);
            ShowHUD();

            selectedWeapon(2);
            scoreCounting(enemyPoints, 1);
            TakeDamage(20);
            ShowHUD();

            selectedWeapon(5);
            scoreCounting(enemyPoints, doublePoints);
            TakeDamage(30);
            ShowHUD();

            selectedWeapon(3);
            scoreCounting(enemyPoints, doublePoints);
            TakeDamage(20);
            ShowHUD();

            selectedWeapon(4);
            scoreCounting(0, 1);
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

        static void selectedWeapon(int weapon)
        {

            string gun;
            
            gun = ("Pistol");

            if (weapon == 1)
            {
                gun = ("Pistol Equipped.");
            }

            if (weapon == 2)
            {
                gun = ("Rifle Equipped.");
            }

            if (weapon == 3)
            {
                gun = ("Shotgun Equipped.");
            }

            if (weapon == 4)
            {
                gun = ("RPG Equipped.");
            }

            if (weapon == 5)
            {
                gun = ("Sniper Equipped.");
            }

            Console.WriteLine("Weapon: " + gun);

        }

        static void scoreCounting(int points, int bonus)
        {

            score = score + points;
            score = score * bonus;

        }
        static void ShowHUD()
        {
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine();
        }
    }     
}

