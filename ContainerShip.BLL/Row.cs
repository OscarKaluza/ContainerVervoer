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
        public int MaxLength { get; set; }

        public Row(Container container, int rowNumber, int length)
        {
            RowNumber = rowNumber;
            MaxLength = length;
            ShipRow = new List<ContainerStack> { new ContainerStack { StackedContainers = new List<Container> { container } } };
        }

        public bool CanAddRow()
        {
            if (ShipRow.Count > MaxLength)
            {
                return false;
            }

            if (ShipRow.Count < MaxLength)
            {
                return true;
            }

            else return false;  
        }

        public bool AddRow(Container container)
        {
            if (CanAddRow())
            {
                ShipRow.Add(new ContainerStack { StackedContainers = new List<Container> { container } });
                return true;
            }
          
            else
            {
                throw new Exception("Cannot add new Row");
            }
        }

    }

}
