using System;
using System.Collections.Generic;
using System.Text;


namespace ContainerShip.BLL
{
    public class Ship
    {
        public Container[,,] ShipLayout { get; set; }
        public int MaximumWeight { get; set; }
        public int LoadedWeight { get; set; }
        public int MaxWeightOnContainer { get; set; }
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
            this.MaxWeightOnContainer = 120000;
            ShipLayout = new Container[length, width, height];
        }

        public void AddContainers(List<Container> containers)
        {
            foreach (var container in containers)
            {
                LoadedWeight += container.Weight;
            }

            if (LoadedWeight < MaximumWeight)
            {
                foreach (var container in containers)
                {
                    if (container.Type == ContainerType.Cooled)
                    {
                        PlaceCooledContainers(new List<Container> { container });
                    }
                    else if (container.Type == ContainerType.Valuable)
                    {
                        PlaceValuableContainers(new List<Container> { container });
                    }
                    else
                    {
                        PlaceContainer(container, 1, 0, 0);
                    }
                }
            }
            else
            {
                throw new Exception($"Ship cannot exceed {MaximumWeight} Kg");
            }
        }

        private void PlaceContainer(Container container, int rowindex, int columnindex, int heightindex)
        {
            int startingRow = rowindex;
            int startingColumn = columnindex;
            int startingHeight = heightindex;

            while (startingRow < Length)
            {
                for (int row = startingRow; row < Length; row++)
                {
                    for (int col = startingColumn; col < Width; col++)
                    {
                        for (int height = startingHeight; height < Height; height++)
                        {
                            if (ShipLayout[row, col, height] == null)
                            {
                                if (CheckMaxWeightOnTop(row, col, height, container.Weight))
                                {
                                    ShipLayout[row, col, height] = container;
                                    Console.WriteLine($"Placed container {container} at position [{row}, {col}, {height}]");
                                    return;
                                }
                            }
                        }
                    }
                }

                startingRow++;
            }

            Console.WriteLine($"Cannot place container. Maximum weight on top of a container is {MaxWeightOnContainer} Kg");
        }

        private bool CheckMaxWeightOnTop(int row, int col, int height, int containerWeight)
        {
            int totalWeightOnTop = containerWeight;

            for (int h = height - 1; h >= 0; h--)
            {
                if (ShipLayout[row, col, h] != null)
                {
                    totalWeightOnTop += ShipLayout[row, col, h].Weight;

                    if (totalWeightOnTop > MaxWeightOnContainer)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void PlaceCooledContainers(List<Container> cooledContainers)
        {
            foreach (var container in cooledContainers)
            {
                if (ShipLayout[0, Width - 1, Height - 1] == null)
                {
                    PlaceContainer(container, 0, 0, 0);
                }
                else
                {
                    throw new Exception("Cant place more cooled containers: Row is full");
                }
            }
        }

        public void PlaceValuableContainers(List<Container> valueableContainers)
        {
            foreach (var container in valueableContainers)
            {
                if (ShipLayout[Length -1, Width - 1, Height - 1] == null)
                {
                    PlaceContainer(container, Length - 1, 0, 0);
                }
                else
                {
                    throw new Exception("Cant place more valueable containers on row for easy acces: Row is full");
                }
            }
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
