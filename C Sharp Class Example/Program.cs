using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Class_Example
{
    public class Character
    {
        public int currentHP;
        public int maxHP;
        public int strength;
        public int speed;
        public int intelligence;

        public void StatDisplay()
        {
            Console.WriteLine($"Current HP = {currentHP}\n" +
                $"Max HP = {maxHP}\n" +
                $"Strength = {strength}\n" +
                $"Speed = {speed}\n" +
                $"Intelligence = {intelligence}");
        }
    }

    class Program
    {
        static void NL()
        {
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Character player = new Character();
            player.currentHP = 20;
            player.maxHP = 20;
            player.strength = 5;
            player.speed = 15;
            player.intelligence = 10;
            Console.WriteLine("Player Stats:");
            player.StatDisplay();
            NL();

            Character goblin = new Character();
            goblin.currentHP = 7;
            goblin.maxHP = 7;
            goblin.strength = 5;
            goblin.speed = 8;
            goblin.intelligence = 3;
            Console.WriteLine("Goblin Stats:");
            goblin.StatDisplay();

            Console.ReadKey();
        }
    }
}
