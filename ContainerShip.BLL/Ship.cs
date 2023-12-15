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
        private int MaxRowLength { get; set; }
        private int MaxContainers { get; set; }
        private int LastRow {  get; set; }
        private int CooledContainerAmount {get ; set; }
        private int ValueAbleContainerAmount { get ; set; } 
        private int ContainerAmount { get; set; }
        private int StartRow {get ; set; }

        public Ship(int lastrow)
        {
            Rows = new List<Row>();
            LastRow = lastrow;
            MaxContainers = 5;
            StartRow = 2;
            ValueAbleContainerAmount = 0;
            ContainerAmount = 0;
            ValueAbleContainerAmount = 0;
        }

        public void DistributeContainers(List<Container> containers)
        {
            foreach (var container in containers)
            {
                if (container.Type == ContainerType.Cooled)
                {
                    AddCooledContainers(container);
                }
                else if (container.Type == ContainerType.Valuable)
                {
                    AddValueableContainers(container);
                }
                else if (container.Type == ContainerType.Empty || container.Type == ContainerType.Full)
                {
                    AddContainers(container);
                }
            }

            DisplayShipInfo(Rows);
        }

        private void AddCooledContainers(Container container)
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

        private void AddValueableContainers(Container container)
        {
            Row row = new Row(LastRow);
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

        private void AddContainers(Container container)
        {
            MaxContainers = 10;

            if (ContainerAmount < MaxContainers)
            {
                Row row = new Row(StartRow);
                row.AddContainer(container);
                Rows.Add(row);
                ContainerAmount++;
            }
            else
            {
                StartRow++;
                ContainerAmount = 1;

                Row newRow = new Row(StartRow);
                newRow.AddContainer(container);
                Rows.Add(newRow);
            }
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
