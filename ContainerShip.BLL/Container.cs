using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip.BLL
{
    public class Container
    {
        public int Weight { get; set; }
        public ContainerType Type { get; set; }

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
                throw new Exception("Weight cannot exceed 30000kg");
            }

        }

        public override string ToString()
        {
            return $"Container: Weight: {Weight} Type: {Type}";
        }
    }
    

}
