using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class Container
    {
        private int Weight { get; set; }
        public ContainerType Type { get; private set; }
        public Container(int weight, ContainerType type)
        {
            Weight = weight;
            Type = type;
        }
        
        public override string ToString()
        {
            return $"Container: Weight {Weight} Type {Type}";
        }
    }
}
