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
        public int MaxHeigth = 5;

        public ContainerStack()
        {
            StackedContainers = new List<Container>();
        }

        public bool CanAddContainer()
        {
            if (StackedContainers.Count < MaxHeigth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ContainerStack> AddContainer(List<Container> containers)
        {
            List<ContainerStack> containerStacks = new List<ContainerStack>();

            if (CanAddContainer())
            {
                foreach (var container in containers)
                {
                    StackedContainers.Add(container);
                }

                containerStacks.Add(new ContainerStack { StackedContainers = containers });
            }
            else
            {
                throw new Exception("Can't stack more containers");
            }

            return containerStacks;
        }


    }
}
