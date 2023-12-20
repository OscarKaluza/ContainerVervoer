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
            Ship ship = new Ship(5, 10, 10);
            ContainerCollection collection = new ContainerCollection();


            ship.DistributeRows(collection.GetContainers());
            Console.ReadLine();
        }
    }
}
