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
            Ship ship = new Ship();
            ContainerCollection collection = new ContainerCollection();

            ship.DistributeContainers(collection.GetContainers());
            Console.ReadLine();
        }
    }
}
