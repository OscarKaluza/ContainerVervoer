using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class Container
    {
        public int MaximumWeight { get; set; }
        public int WeightOnContainer { get; set; }
        public bool Valuable { get; set; }
        public bool Cooled { get; set; }
    }
}
