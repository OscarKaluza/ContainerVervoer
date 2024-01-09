using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Containertest;
using ContainerVervoer.Core;

namespace Test_Layer
{
    public class Ship_Tests
    {
        [Fact]

        public void Check_If_Stacks_Are_Distributed_Correctly()
        {
            Ship ship = new Ship(30000, 10);
            ContainerCollection collection = new ContainerCollection();

            ship.DistributeRows(collection.GetContainers());
            
            Assert.NotNull(ship.ContainerStacks);
            Assert.NotEmpty(ship.ContainerStacks);
            Assert.IsType<List<ContainerStack>>(ship.ContainerStacks);
            Assert.Equal(ship.ContainerStacks[0].Rows[0].Containers[0].Type, ContainerType.Cooled); //Checks if Cooled Containers are on the first Stack
            Assert.Equal(ship.ContainerStacks[2].Rows[0].Containers[0].Type, ContainerType.Empty); //Checks if Empty Containers are on the Middle Stack
            Assert.Equal(ship.ContainerStacks[6].Rows[0].Containers[0].Type, ContainerType.Valuable); //Checks if Valueable Containers are on the Last Stack

        }
    }
}
