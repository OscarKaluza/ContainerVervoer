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
            Ship ship = new Ship(1000, 2, 2);

            BLL.Container container1 = new BLL.Container(100, ContainerType.Valuable);
            BLL.Container container2 = new BLL.Container(200, ContainerType.Cooled);
            BLL.Container container3 = new BLL.Container(400, ContainerType.Valuable);
            BLL.Container container4 = new BLL.Container(100, ContainerType.Valuable);

            ship.ShipLayout[0,0] = container1;
            ship.ShipLayout[0,1] = container2;
            ship.ShipLayout[1,0] = container3;
            ship.ShipLayout[1,1] = container4;


            for (int i =0; i < ship.ShipLayout.GetLength(0); i++)
            {
                for (int j = 0; j < ship.ShipLayout.GetLength(1); j++)
                {
                    Console.WriteLine(ship.ShipLayout[i, j]);
                }
            }


            Console.ReadLine();

        }
    }
}
