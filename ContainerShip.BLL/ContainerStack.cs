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
        public List<Container> StackedContainers { get; set; }
        public int MaxHeight = 5;

        public ContainerStack()
        {
            StackedContainers = new List<Container>();
        }

        public bool CanAddContainer()
        {
            return StackedContainers.Count < MaxHeight; 
        }

        public void AddContainer(Container container)
        {
            if (CanAddContainer())
            {
                StackedContainers.Add(container);
            }
            else
            {
                throw new Exception("Cant stack more containers");
            }
        }

    }
}
