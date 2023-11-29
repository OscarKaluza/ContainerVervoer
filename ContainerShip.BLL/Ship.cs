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

        private int Length { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }

        public Ship(int maximumWeight, int length, int width, int height)
        {
            this.MaximumWeight = maximumWeight;
            this.LoadedWeight = 0;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            ShipLayout = new Container[length, width, height];
        }

        public void AddContainers(List<Container> containers)
        {
            foreach (var container in containers)
            {
                if (container.Type == ContainerType.Cooled)
                {
                    PlaceContainer(container, 0);
                }
                else
                {
                    PlaceContainer(container, 1);
                }
            }
        }


        private void PlaceContainer(Container container, int rowindex)
        {
            for (int row = rowindex; row < Length; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    for (int level = 0; level < Height; level++)
                    {
                        if (ShipLayout[row, col, level] == null)
                        {
                            ShipLayout[row, col, level] = container;
                            LoadedWeight += container.Weight;
                            Console.WriteLine($"Placed container {container} at position [{row}, {col}, {level}]");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No available space to place the container.");
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int x = 0; x < ShipLayout.GetLength(0); x++)
            {
                for (int y = 0; y < ShipLayout.GetLength(1); y++)
                {
                    for (int z = 0; z < ShipLayout.GetLength(2); z++)
                    {
                        if (ShipLayout[x, y, z] != null)
                        {
                            sb.Append($"[{x}, {y}, {z}]: {ShipLayout[x, y, z]}\n");
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}
