using ContainerShip.BLL;

namespace Test_Layer
{
    public class UnitTest1
    {
        [Fact]
        public void CheckIfCooledContainersArePlacedInTheFirstRow()
        {
            Ship ship = new Ship(3000000, 6, 6, 6);
            ContainerCollection containers = new ContainerCollection();

            ship.AddContainers(containers.GetContainers());

            Assert.True(AreCooledContainersInFirstRow(ship.ShipLayout));
        }

        private bool AreCooledContainersInFirstRow(Container[,,] containers)
        {
            for (int i = 0; i < containers.GetLength(1); i++)
            {
                for (int j = 0; j < containers.GetLength(2); j++)
                {
                    if (containers[0, i, j] != null && containers[0, i, j].Type == ContainerType.Cooled)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}