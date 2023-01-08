using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3and4_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Armour armour = new Armour("Helm of the Overlord", ArmourType.Helmet, 6175);

            Warrior warrior = new Warrior("Axe", 700, 55, armour);
            warrior.ShowInfo();
            Console.ReadKey();

            List<House> houses = new List<House>();

            for (int i = 0; i < 10; i++)
            {
                House cottage = new Cottage("томск", "вова", 10, 100, 15, true);
                House flat = new Flat("томск", "вова", 10, 100);
                houses.Add(cottage);
                houses.Add(flat);
            }

            Console.ReadKey();
        }
    }
}
