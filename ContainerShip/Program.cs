using ContainerShip.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContainerCollection containers = new ContainerCollection();
            Ship ship = new Ship(1000, 10, 10, 10);


            ship.AddContainer(containers.GetContainers());

            Console.WriteLine(ship.ShipLayout);
            Console.ReadLine();

        }
    }
}
