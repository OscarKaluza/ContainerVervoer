using ContainerVervoer.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containertest
{
    public class Row
    {
        public int RowNumber { get; set; }
        public List<Container> Containers { get; set; }

        public Row(int rownumber)
        {
            this.RowNumber = rownumber;
            this.Containers = new List<Container>();
        }


        public void AddContainer(Container container)
        {
            Containers.Add(container);
        }
    }
}
