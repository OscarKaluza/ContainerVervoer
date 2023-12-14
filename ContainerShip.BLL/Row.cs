using System.Collections.Generic;

namespace ContainerVervoer.Core
{
    public class Row
    {
        public List<ContainerStack> ShipRow { get; set; }
        public int RowNumber { get; set; }

        public List<Row> AddStack(List<Container> containers)
        {
            List<Row> rows = new List<Row>();

            foreach (var container in containers)
            {
                Row row = new Row
                {
                    ShipRow = new List<ContainerStack>
                    {
                        new ContainerStack
                        {
                            StackedContainers = new List<Container> { container }
                        }
                    }
                };

                rows.Add(row);
            }

            return rows;
        }

    }

}
