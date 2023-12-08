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
                if (container.Type != ContainerType.Cooled)
                {
                    int startrow = 2;
                    Rows.Add(new Row(container, startrow++, 5));
                }
                else if (container.Type == ContainerType.Cooled)
                {
                    Rows.Add(new Row(container, 1, 100));
                }
            }

        }


        public void DisplayShipInfo()
        {
            foreach (var row in Rows)
            {
                foreach (var stack in row.ShipRow)
                {
                    foreach (var container in stack.Stack)
                    {
                        Console.WriteLine($"Row {row.RowNumber} | Container Type: {container.Type}");
                    }
                }
            }
        }

    }
}
