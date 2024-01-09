using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainerVervoer.Core
{
    public class Ship
    {
        public List<ContainerStack> ContainerStacks = new List<ContainerStack>();
        public int MaxWeight { get; set; }
        private int Length { get; set; }
        private int StartRow { get; set; }
        private int CooledContainerAmount { get; set; }
        private int ValueAbleContainerAmount { get; set; }
        private int ContainerAmount { get; set; }
        private int LoadedWeigth { get; set;  }

        public Ship(int maxWeight, int lastrow)
        {
            Length = lastrow;
            StartRow = 2;
            MaxWeight = maxWeight;
        }

        public void DistributeRows(List<Container> containers)
        {
            foreach (var container in containers)
            {
                if (container.Type == ContainerType.Cooled)
                {
                    AddContainerToStack(AddCooledContainers(container));
                }
                else if (container.Type == ContainerType.Valuable)
                {
                    AddContainerToStack(AddValueableContainers(container));
                }
                else if (container.Type == ContainerType.Empty || container.Type == ContainerType.Full)
                {
                    AddContainerToStack(AddRegularContainers(container));
                }
            }
        }

        private void AddContainerToStack(Row row)
        {
            var existingStack = ContainerStacks.FirstOrDefault(stack => stack.RowNumber == row.RowNumber);

            if (existingStack != null)
            {
                existingStack.AddRow(row);
            }
            else
            {
                ContainerStack stack = new ContainerStack(row.RowNumber, 5);
                stack.AddRow(row);
                ContainerStacks.Add(stack);
            }
        }

        private Row AddCooledContainers(Container container)
        {
            Row CooledRow = new Row(1, 5);
            CooledContainerAmount++;

            if (!CooledRow.CanAddContainer())
            {
                throw new Exception("Cannot add more cooled containers to the ship:");
            }

            CooledRow.AddContainer(container);
            return CooledRow;
        }

        private Row AddValueableContainers(Container container)
        {
            Row ValueableRow = new Row(Length, 10);
            ValueAbleContainerAmount++;

            if (!ValueableRow.CanAddContainer())
            {
                throw new Exception("Cannot add more valuable containers to the ship:");
            }

            ValueableRow.AddContainer(container);
            return ValueableRow;
        }

        private Row AddRegularContainers(Container container)
        {
            Row row = new Row(StartRow, 3);

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

                Row newRow = new Row(StartRow, row.MaxContainers);
                newRow.AddContainer(container);
                return newRow;
            }
        }

        public int CalculateLoadedWeight(List<Container> containersToAdd)
        {
            int loadedWeight = 0;

            foreach (var containerStack in ContainerStacks)
            {
                foreach (var row in containerStack.Rows)
                {
                    foreach (var container in row.Containers)
                    {
                        loadedWeight += container.Weight;
                    }
                }
            }

            foreach (var container in containersToAdd)
            {
                loadedWeight += container.Weight;
            }

            return loadedWeight;
        }



        public void DisplayShipInfo(List<ContainerStack> stacks)
        {
            var sortedStacks = stacks.OrderBy(stack => stack.RowNumber).ToList();

            foreach (ContainerStack stack in sortedStacks)
            {
                Console.WriteLine($"Container Stack: {stack.RowNumber} | Height: {stack.StackNumber}");

                foreach (Row row in stack.Rows)
                {
                    for (int i = 0; i < row.Containers.Count; i++)
                    {
                        Console.WriteLine($"  Row: {row.RowNumber} | Type: {row.Containers[i].Type} | Weight: {row.Containers[i].Weight}");
                    }
                }
            }
        }


    }
}