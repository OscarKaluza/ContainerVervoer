using ContainerVervoer.Core;
using System;
using System.Collections.Generic;

namespace ContainerVervoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContainerCollection containerCollection = new ContainerCollection();
            Ship ship = new Ship(1, 100, 5);    
            Row row = new Row();
            List<Row> newRows = row.AddStack(containerCollection.GetContainers());

            ship.AddRows(newRows);
            ship.DisplayShipInfo();
            Console.ReadLine();
        }
    }
}
