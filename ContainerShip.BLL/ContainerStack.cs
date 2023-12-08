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
        public List<Container> Stack { get; set; }

        public ContainerStack()
        {
            Stack = new List<Container>();
        }
    }
}
