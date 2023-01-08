using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3and4_Task
{
    public class House
    {
        public string Address { get; set; }

        private string _owner;

        public string Owner
        {
            get { return _owner;}
            set
            {
                if (int.TryParse(value, out int x))
                {
                    Console.WriteLine("Не число");
                }
                else
                {
                    _owner = value;
                }
            }
        }

        private int _countOfRooms;

        public int CountOfRooms
        {
            get
            {
                return _countOfRooms;
            }
            set
            {
                if (value > 0)
                {
                    _countOfRooms = value;
                }
            }
        }

        public House(string address, string owner, int countOfRooms)
        {
            Address = address;
            Owner = owner;
            CountOfRooms = countOfRooms;
        }
    }
}
