using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3and4_Task
{
    public class Cottage : House
    {
        private int _garageArea;

        private int _backyardArea;

        private bool _dogHouse;

        public int GarageArea
        {
            get { return _garageArea;}
            set
            {
                if (value >= 0)
                {
                    _garageArea = value;
                }
            }
        }

        public int BackyardArea
        {
            get { return _backyardArea; }
            set
            {
                if (value >= 0)
                {
                    _backyardArea = value;
                }
            }
        }

        public bool DogHouse { get; set; }

        public Cottage(string address, string owner, int countOfRooms,
            int garageArea, int backYardArea, bool dogHouse) : base(address, owner, countOfRooms)
        {
            GarageArea = garageArea;
            BackyardArea = backYardArea;
            DogHouse = dogHouse;
        }
    }
}
