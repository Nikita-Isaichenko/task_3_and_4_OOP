using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3and4_Task
{
    public class Armour
    {
        private string _name;

        private ArmourType _type;

        private int _cost;

        public string Name { get; set; }

        public ArmourType Type { get; set; }

        public int Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value > 0)
                {
                    _cost = value;
                }
                else
                {
                    Console.WriteLine("Cost должна быть больше 0");
                }
            }
        }

        public Armour(string name, ArmourType armour, int cost)
        {
            Name = name;
            Type = armour;
            Cost = cost;
        }

        public string GetInfo()
        {
            return $"Название: {Name},\n Тип: {Type},\n Цена: {Cost}";

        }
    }
}
