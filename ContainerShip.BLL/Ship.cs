using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class Ship
    {
        private List<Row> Rows = new List<Row>();
        private int Length { get; set; }
        private int StartRow { get; set; }
        private int CooledContainerAmount { get; set; }
        private int ValueAbleContainerAmount { get; set; }
        private int ContainerAmount { get; set; }


        public Ship(int lastrow)
        {
            Length = lastrow;
            StartRow = 2;
        }
        public void DistributeRows(List<Container> containers)
        {
            foreach (var container in containers)
            {
                if (container.Type == ContainerType.Cooled)
                {
                    Rows.Add(AddCooledContainers(container));
                }
                else if (container.Type == ContainerType.Valuable)
                {
                    Rows.Add(AddValueableContainers(container));
                }
                else if (container.Type == ContainerType.Empty || container.Type == ContainerType.Full)
                {
                    Rows.Add(AddContainers(container));
                }
            }

            DisplayShipInfo(Rows);
        }

        public Row AddCooledContainers(Container container)
        {
            Row row = new Row(1);
            row.MaxContainers = 5;

            if (CooledContainerAmount < row.MaxContainers)
            {
                row.AddContainer(container);
                CooledContainerAmount++;
            }
            else
            {
                throw new Exception("Cannot add more cooled containers to the ship:");
            }
            return row;
        }

        public Row AddValueableContainers(Container container)
        {
            Row row = new Row(Length);
            row.MaxContainers = 10;

            if (ValueAbleContainerAmount < Length - 1)
            {
                row.AddContainer(container);
                ValueAbleContainerAmount++;
            }
            else
            {
                throw new Exception("Cannot add more valuable containers to the ship:");
            }
            return row;
        }

        public Row AddContainers(Container container)
        {
            Row row = new Row(StartRow);
            row.MaxContainers = 2;

            if (ContainerAmount < row.MaxContainers)
            {
                row.AddContainer(container);
                ContainerAmount++;
                return row;
            } 

            else
            {
                StartRow++;
                ContainerAmount = 1;

                if (StartRow >= Length)
                {
                    throw new Exception("Cannot add more rows to the ship");
                }

                Row newRow = new Row(StartRow);
                newRow.AddContainer(container);
                return newRow;
            }
        }

        public void DisplayShipInfo(List<Row> rows)
        {
            var sortedRows = rows.OrderBy(row => row.RowNumber).ToList();

            foreach (Row row in sortedRows)
            {
                for (int i = 0; i < row.Containers.Count; i++)
                {
                    Console.WriteLine($"Row: {row.RowNumber} | Type: {row.Containers[i].Type} | Weigth: {row.Containers[i].Weight}");
                }
            }
        }

    }
}
