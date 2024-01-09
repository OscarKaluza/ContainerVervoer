using ContainerVervoer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerVervoer;
using Containertest;

namespace ContainerVervoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(300000, 10);
            ContainerCollection collection = new ContainerCollection();

            List<Container> containersToAdd = collection.GetContainers();

            if (ship.CalculateLoadedWeight(containersToAdd) > ship.MaxWeight)
            {
                throw new Exception("Cannot add more containers");
            }

            ship.DistributeRows(containersToAdd);
            ship.DisplayShipInfo(ship.ContainerStacks);
            Console.ReadLine();

        }
    }
}
