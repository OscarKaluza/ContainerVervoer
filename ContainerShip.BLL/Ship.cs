using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class Ship
    {
        public List<Row> Rows { get; set; }
        public Ship()
        {
            Rows = new List<Row>();
        }

        public void DistributeContainers(List<Container> containers)
        {
            foreach (var container in containers)
            {
                bool containerAdded = false;

                foreach (var row in Rows)
                {
                    if (row.CanAddContainer(container))
                    {
                        row.AddContainer(container);
                        containerAdded = true;
                        break;
                    }
                }

                if (!containerAdded)
                {
                    Rows.Add(new Row(container, Rows.Count + 1));
                }
            }
        }

        public void DisplayShipInfo()
        {
            foreach (var row in Rows)
            {
                Console.WriteLine($"Row {row.RowNumber} - Length: {row.RowLength} - Height: ---");

                foreach (var stack in row.ShipRow)
                {
                    foreach (var container in stack.Stack)
                    {
                        Console.WriteLine($"  Container Type: {container.Type} ");
                    }
                }
            }
        }

    }
}
