using ContainerVervoer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containertest
{
    public class Ship
    {
        public int MaxRowLength { get; set; }
        public int MaxContainers { get; set; }

        private List<Row> Rows = new List<Row>();

        public Ship()
        {
            Rows = new List<Row>();
            MaxContainers = 5;
        }

        public void DistributeContainers(List<Container> containers)
        {
            int startRow = 2;
            int currentcontainers = 0;

            foreach (var container in containers)
            {
                if (container.Type == ContainerType.Cooled)
                {
                    Row row = new Row(1);
                    MaxContainers = 5;

                    if (currentcontainers < MaxContainers)
                    {
                        row.AddContainer(container);
                        Rows.Add(row);
                        currentcontainers++;
                    }
                    else
                    {
                        throw new Exception("Cannot add more cooled containers to the ship:");
                    }

                }

                else if (container.Type == ContainerType.Valuable)
                {
                    if (currentcontainers < MaxContainers)
                    {
                        Row row = new Row(3);
                        row.AddContainer(container);
                        Rows.Add(row);
                    }
                    else
                    {
                        throw new Exception("Cannot add more valueable containers to the ship:");

                    }

                }

                else
                {
                    Row row = new Row(startRow);
                    row.Containers.Add(container);
                    Rows.Add(row);
                }
            }

            DisplayShipInfo(Rows);
        }


        public void DisplayShipInfo(List<Row> rows)
        {
            var sortedRows = rows.OrderBy(row => row.RowNumber).ToList();

            foreach (Row row in sortedRows)
            {
                for (int i = 0; i < row.Containers.Count; i++)
                {
                    Console.WriteLine($"Row: {row.RowNumber} | Type: {row.Containers[i].Type}");
                }
            }
        }

    }
}
