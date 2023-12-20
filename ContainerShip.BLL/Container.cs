using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class Container
    {
        public ContainerType Type { get; private set; }
        public int Weight { get; private set; }
        public int MaxWeight { get; set; }


        public Container(int weight, ContainerType type)
        {
            MaxWeight = 30000;
            Weight = weight;
            Type = type;

            if (weight > MaxWeight)
            {
                throw new Exception($"Weight cannot exceed {MaxWeight}");
            }

        }
        
        public override string ToString()
        {
            return $"Container: Weight {Weight} Type {Type}";
        }
    }
}
