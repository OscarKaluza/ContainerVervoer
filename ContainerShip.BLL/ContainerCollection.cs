using ContainerVervoer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class ContainerCollection
    {
        public List<Container> GetContainers()
        {
            List<Container> containers = new List<Container>
            {
                new Container(4000, ContainerType.Empty),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),
                new Container(5000, ContainerType.Valuable),

            };

            return containers;
        }
    }
}
