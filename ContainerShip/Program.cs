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
            Ship ship = new Ship(1000, 10, 10, 10);

            List<BLL.Container> containers = new List<BLL.Container>();

            containers.Add(new BLL.Container(400, ContainerType.Empty));
            containers.Add(new BLL.Container(400, ContainerType.Empty));
            containers.Add(new BLL.Container(1000, ContainerType.Full));
            containers.Add(new BLL.Container(1275, ContainerType.Full));
            containers.Add(new BLL.Container(800, ContainerType.Cooled));
            containers.Add(new BLL.Container(810, ContainerType.Cooled));
            containers.Add(new BLL.Container(1500, ContainerType.Valuable));
            containers.Add(new BLL.Container(1477, ContainerType.Valuable));

            ship.AddContainer(containers);

            Console.WriteLine(ship.ShipLayout);
            Console.ReadLine();

        }
    }
}
