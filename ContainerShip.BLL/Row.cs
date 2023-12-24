using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class Row
    {
        public int RowNumber { get; private set; }
        public List<Container> Containers { get; private set; }
        public int MaxContainers {get; private set; }

        public Row(int rownumber, int maxcontainers)
        {
            this.RowNumber = rownumber;
            this.MaxContainers = maxcontainers;
            this.Containers = new List<Container>();
        }

        public void AddContainer(Container container)
        {
            Containers.Add(container);
        }

        public bool CanAddContainer()
        {
            if (Containers.Count >= MaxContainers)
            {
                return false;
            }

            else return true;
        }
    }
}
