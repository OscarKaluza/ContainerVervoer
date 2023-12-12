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
        public List<Row> Layout { get; set; }
        public Ship()
        {
            Layout = new List<Row>();
        }


        public void DistributeContainers(List<Container> containers)
        {
            foreach (var container in containers)
            {
                if (container.Type != ContainerType.Cooled)
                {
                    int startrow = 2;
                    Row row = new Row(container, startrow, 5);

                    if (row.AddRow(container))
                    {
                        Layout.Add(row);
                    }
                    else
                    {
                        startrow = 3;
                        Layout.Add(new Row(container, startrow, 5));
                    }
                }
                else if (container.Type == ContainerType.Cooled)
                {
                    Layout.Add(new Row(container, 1, 5));
                }
            }
        }

        public void DisplayShipInfo()
        {
            var sortedRows = Layout.OrderBy(row => row.RowNumber);

            foreach (var row in sortedRows)
            {
                foreach (var stack in row.ShipRow)
                {
                    foreach (var container in stack.StackedContainers)
                    {
                        Console.WriteLine($"Row {row.RowNumber} | Container Type: {container.Type} amount on top {stack.StackedContainers.Count -1}");
                    }
                }
            }
        }


    }
}
