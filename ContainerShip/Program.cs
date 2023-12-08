using ContainerVervoer.Core;
using System;
using System.Collections.Generic;

namespace ContainerVervoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            ContainerCollection containers = new ContainerCollection();

            ship.DistributeContainers(containers.GetContainers());
            ship.DisplayShipInfo();

            //foreach (var row in ship.Rows)
            //{
            //    foreach (var containerStack in row.ShipRow)
            //    {
            //        foreach (var container in containerStack.Stack)
            //        {
            //            Console.WriteLine($"Row: {row.RowNumber}  Weight: {container.Weight} Kg, ContainerType: {container.Type}");
            //        }
            //    }
            //}
            Console.ReadLine();
        }
    }
}
