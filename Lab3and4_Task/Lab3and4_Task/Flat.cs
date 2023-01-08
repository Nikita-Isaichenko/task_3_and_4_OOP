using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3and4_Task
{
    public class Flat : House
    {

        public int Floor { get; set; }

        public string FavoriteToy { get; set; }

        public Flat(string address, string owner, int countOfRooms, int floor) : base(address, owner, countOfRooms)
        {
            Floor = floor;
        }
    }
}
