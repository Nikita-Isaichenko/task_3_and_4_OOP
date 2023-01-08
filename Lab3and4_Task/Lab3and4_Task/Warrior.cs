using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3and4_Task
{
    public class Warrior
    {
        private string _name;

        private int _hp;

        private int _damage;

        private Armour _equipment;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                if (value > 0)
                {
                    _hp = value;
                }
                else
                {
                    Console.WriteLine("HP должно быть больше 0");
                }
            }
        }

        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                if (value > 0)
                {
                    _damage = value;
                }
                else
                {
                    Console.WriteLine("Damage должно быть больше 0");
                }
            }
        }

        public Armour Equipment { get; set; }

        public Warrior(string name, int hp, int damage, Armour armour)
        {
            Name = name;
            HP = hp;
            Damage = damage;
            Equipment = armour;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Здоровье: {HP}");
            Console.WriteLine($"Урон: {Damage}");
            Console.WriteLine($"Броня: {Equipment.GetInfo()}");
        }

    }
}