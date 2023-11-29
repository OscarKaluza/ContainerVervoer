using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ContainerShip.BLL
{
    public class Ship
    {
        public int MaximumWeight { get; set; }
        public int LoadedWeight { get; set; }

        public int MaxWeightOnContainer = 120000;
        public Container[,,] ShipLayout { get; set; }

        public Ship(int maximumWeight, int length, int width, int height)
        {
            ShipLayout = new Container[length, width, height];
            this.MaximumWeight = maximumWeight;
        }

        public void AddContainer(List<Container> containers)
        {
            int containerIndex = 0;

            for (int x = 0; x < ShipLayout.GetLength(0); x++)
            {
                for (int y = 0; y < ShipLayout.GetLength(1); y++)
                {
                    for (int z = 0; z < ShipLayout.GetLength(2); z++)
                    {
                        if (containerIndex < containers.Count)
                        {
                            ShipLayout[x, y, z] = containers[containerIndex];
                            containerIndex++;
                        }
                        else
                        {
                            // If ShipLayout dimensions are smaller than containers count, exit the loop.
                            break;
                        }
                    }

                    if (containerIndex >= containers.Count)
                    {
                        // If ShipLayout dimensions are smaller than containers count, exit the loop.
                        break;
                    }
                }

                if (containerIndex >= containers.Count)
                {
                    // If ShipLayout dimensions are smaller than containers count, exit the loop.
                    break;
                }
            }
        }




    }
}
