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
            List<Container> containers = new List<Container>
            {
                new Container(4000, ContainerType.Empty),
                new Container(5000, ContainerType.Valuable),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Full),

            };


            ship.DistributeContainers(containers);
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
