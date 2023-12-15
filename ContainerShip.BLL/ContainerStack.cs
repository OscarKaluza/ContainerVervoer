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
        public List<Row> StackedRows { get; set; }

        public const int MAXHEIGHT = 5;

        public ContainerStack()
        {
            StackedRows = new List<Row>();
        }

       

        public List<Row> AddContainer(List<Row> rows)
        {
            StackedRows = new List<Row>();

            foreach (var row in rows)
            {
                StackedRows.Add(row);
            }

            return StackedRows;
        }


    }
}
