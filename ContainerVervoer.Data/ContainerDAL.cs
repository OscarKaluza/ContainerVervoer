using ContainerVervoer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Data
{
    public class ContainerDAL
    {
        public List<Container> Containers { get; set; }
        public List<Container> GetContainers()
        {
            List<Container> containers = new List<Container>
            {
                new Container(4000, ContainerType.Empty),
                new Container(5000, ContainerType.Valuable),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(10000, ContainerType.Cooled),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Full),
                new Container(7000, ContainerType.Full),
            };

            return containers;
        }
    }
}
