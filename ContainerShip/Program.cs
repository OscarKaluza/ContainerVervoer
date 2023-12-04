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
            Ship ship = new Ship(3000000, 6, 6, 6);

            ship.AddContainers(containers.GetContainers());

            Console.WriteLine(ship);
            Console.ReadLine();

        }
    }
}
