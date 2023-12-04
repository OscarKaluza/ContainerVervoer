using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip.BLL
{
    public class Container
    {
        public ContainerType Type { get; set; }
        public int Weight { get; set; }
        public int maxWeight = 30000;

        public Container(int weight, ContainerType type)
        {
            this.Type = type;
            if (weight <= maxWeight)
            {
                Weight = weight;
            }
            else
            {
                throw new Exception($"Weight cannot exceed {maxWeight}");
            }
        }

        public Container(ContainerType type)
        {
            this.Type = type;

            if (type == ContainerType.Empty)
            {
                Weight = 4000;
            }
            else if (type != ContainerType.Empty)
            {
                throw new Exception("Cannot add the container, please specify the weight");
            }
        }
        public override string ToString()
        {
            return $"Container: Weight: {Weight} Type: {Type}";
        }
    }
    

}
