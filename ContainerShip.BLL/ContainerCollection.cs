using Containertest;
using ContainerVervoer.Core;
using System.Collections.Generic;

namespace Containertest
{
    public class ContainerCollection
    {
        public List<Container> GetContainers()
        {
            List<Container> containers = new List<Container>
            {
                new Container(4000, ContainerType.Empty),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Cooled),
                new Container(5000, ContainerType.Cooled),
                new Container(4000, ContainerType.Empty),
                new Container(4124, ContainerType.Empty),
                new Container(4000, ContainerType.Empty),
                new Container(4000, ContainerType.Empty),
                new Container(4000, ContainerType.Empty),
                new Container(4000, ContainerType.Empty),
                new Container(4000, ContainerType.Full),
                new Container(4000, ContainerType.Full),
                new Container(4000, ContainerType.Full),
                new Container(4000, ContainerType.Full),
                new Container(4000, ContainerType.Full),
                new Container(4000, ContainerType.Full),
                new Container(4000, ContainerType.Full),
                new Container(4000, ContainerType.Full),
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
