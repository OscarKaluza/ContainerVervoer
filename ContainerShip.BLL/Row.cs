using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class Row
    {
        public List<ContainerStack> ShipRow { get; set; }
        public int RowNumber { get ; set; }  
        public Row(int rownumber)
        {
            RowNumber = rownumber;
        }

        public Row() { }

        public List<Row> AddStack(List<Container> containers)
        {
            List<Row> rows = new List<Row>();

            foreach (var container in containers)
            {
                Row row = new Row
                {
                    ShipRow = new List<ContainerStack>
            {
                new ContainerStack
                {
                    StackedContainers = new List<Container> { container }
                }
            }
                };

                rows.Add(row);
            }

            return rows;
        }




    }

}
