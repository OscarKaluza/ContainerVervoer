using ContainerVervoer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containertest
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
