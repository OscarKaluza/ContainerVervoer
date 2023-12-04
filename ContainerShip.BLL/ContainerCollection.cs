using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip.BLL
{
    public class ContainerCollection
    {
        public List<Container> containers {  get; set; }    

        public List<Container> GetContainers()
        {
            containers = new List<Container>();

            containers.Add(new BLL.Container(ContainerType.Empty));
            containers.Add(new BLL.Container(ContainerType.Empty));
            containers.Add(new BLL.Container(ContainerType.Empty));
            containers.Add(new BLL.Container(ContainerType.Empty));
            containers.Add(new BLL.Container(1000, ContainerType.Full));
            containers.Add(new BLL.Container(1000, ContainerType.Full));
            containers.Add(new BLL.Container(1000, ContainerType.Full));
            containers.Add(new BLL.Container(1000, ContainerType.Full));
            containers.Add(new BLL.Container(1000, ContainerType.Full));
            containers.Add(new BLL.Container(1000, ContainerType.Full));
            containers.Add(new BLL.Container(1275, ContainerType.Full));
            containers.Add(new BLL.Container(800, ContainerType.Cooled));
            containers.Add(new BLL.Container(1500, ContainerType.Valuable));
            containers.Add(new BLL.Container(1477, ContainerType.Valuable));
            containers.Add(new BLL.Container(1000, ContainerType.Cooled));
            containers.Add(new BLL.Container(30000, ContainerType.Cooled));
            containers.Add(new BLL.Container(30000, ContainerType.Cooled));
            containers.Add(new BLL.Container(4000, ContainerType.Cooled));
            containers.Add(new BLL.Container(7000, ContainerType.Cooled));
            containers.Add(new BLL.Container(1500, ContainerType.Valuable));
            containers.Add(new BLL.Container(1500, ContainerType.Valuable));
            containers.Add(new BLL.Container(1500, ContainerType.Valuable));
            containers.Add(new BLL.Container(1500, ContainerType.Valuable));
            containers.Add(new BLL.Container(30000, ContainerType.Cooled));
            containers.Add(new BLL.Container(30000, ContainerType.Cooled));
            containers.Add(new BLL.Container(20000, ContainerType.Cooled));
            containers.Add(new BLL.Container(20000, ContainerType.Cooled));
            containers.Add(new BLL.Container(20000, ContainerType.Cooled));
            containers.Add(new BLL.Container(20000, ContainerType.Cooled));
            containers.Add(new BLL.Container(20000, ContainerType.Cooled));
            containers.Add(new BLL.Container(10000, ContainerType.Cooled));
            containers.Add(new BLL.Container(810, ContainerType.Cooled));
            containers.Add(new BLL.Container(30000, ContainerType.Full));
            containers.Add(new BLL.Container(30000, ContainerType.Full));
            containers.Add(new BLL.Container(30000, ContainerType.Full));
            containers.Add(new BLL.Container(30000, ContainerType.Full));
            containers.Add(new BLL.Container(30000, ContainerType.Full));
            containers.Add(new BLL.Container(30000, ContainerType.Full));
            containers.Add(new BLL.Container(30000, ContainerType.Full));
            containers.Add(new BLL.Container(30000, ContainerType.Full));
            containers.Add(new BLL.Container(30000, ContainerType.Full));


            return containers;
        }


    }
}
