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
        private List<Row> Rows = new List<Row>();
        public int MaxRowLength { get; set; }
        public int MaxContainers { get; set; }

        private int CooledContainerAmount = 0;
        private int ValueAbleContainerAmount = 0;

        public Ship()
        {
            Rows = new List<Row>();
            MaxContainers = 5;
        }

        public void DistributeContainers(List<Container> containers)
        {
            int startRow = 2;

            foreach (var container in containers)
            {
                if (container.Type == ContainerType.Cooled)
                {
                    DistributeCooledContainer(container);
                }
                else if (container.Type == ContainerType.Valuable)
                {
                    DistributeValuableContainer(container);
                }
                else
                {
                    DistributeRegularContainer(container, startRow);
                }
            }

            DisplayShipInfo(Rows);
        }

        private void DistributeCooledContainer(Container container)
        {
            Row row = new Row(1);
            MaxContainers = 5;

            if (CooledContainerAmount < MaxContainers)
            {
                row.AddContainer(container);
                Rows.Add(row);
                CooledContainerAmount++;
            }
            else
            {
                throw new Exception("Cannot add more cooled containers to the ship:");
            }
        }

        private void DistributeValuableContainer(Container container)
        {
            Row row = new Row(3);
            MaxContainers = 10;

            if (ValueAbleContainerAmount < MaxContainers)
            {
                row.AddContainer(container);
                Rows.Add(row);
                ValueAbleContainerAmount++;
            }
            else
            {
                throw new Exception("Cannot add more valuable containers to the ship:");
            }
        }

        private void DistributeRegularContainer(Container container, int startRow)
        {
            Row row = new Row(startRow);
            row.Containers.Add(container);
            Rows.Add(row);
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
