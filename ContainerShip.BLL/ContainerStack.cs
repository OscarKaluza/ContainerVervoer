using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class ContainerStack
    {
        public int RowNumber { get; private set; }
        public int StackNumber { get; private set; } 
        public List<Row> Rows { get; } = new List<Row>();

        public ContainerStack(int rowNumber, int stacknumber)
        {
            RowNumber = rowNumber;
            StackNumber = stacknumber;
        }

        public void AddRow(Row row)
        {
            Rows.Add(row);
        }
    }
}
