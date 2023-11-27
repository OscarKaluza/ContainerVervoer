using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContainerShip.BLL
{
    public class Ship
    {
        public int MaximumWeight { get; set; }

        public Container[,] ShipLayout { get; set; }

        public List<Container> containers { get; set; }

        public Ship(int maximumWeight, int lenght, int width)
        {
            ShipLayout = new Container[lenght, width];
            this.MaximumWeight = maximumWeight;
        }
    }
}
