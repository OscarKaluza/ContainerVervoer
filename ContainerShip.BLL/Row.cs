using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class Row
    {
        public List<ContainerStack> ShipRow { get; set; }
        public int RowNumber { get; set; }
        public int RowLength { get; set; }

        public Row(Container container, int rowNumber, int length)
        {
            RowNumber = rowNumber;
            RowLength = length;
            ShipRow = new List<ContainerStack> { new ContainerStack { Stack = new List<Container> { container } } };
        }

        public bool CanAddContainer(Container container)
        {
            int currentRowLength = ShipRow.Sum(stack => stack.Stack.Count);
            return currentRowLength + 1 <= RowLength;
        }

        public void AddContainer(Container container)
        {
            foreach (var stack in ShipRow)
            {
                if (stack.Stack.Count < RowLength)
                {
                    stack.Stack.Add(container);
                    return;
                }
            }

            ShipRow.Add(new ContainerStack { Stack = new List<Container> { container } });
        }

        public bool IsFull()
        {
            return ShipRow.Count >= RowLength;
        }
    }

}
