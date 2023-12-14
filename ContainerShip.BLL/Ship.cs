using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Core
{
    public class Ship
    {
        public List<Row> Layout { get; set; }
        public int RowNumber {  get; set; }
        public int MaxRowLength { get; set; }
        public int MaxRowWidth { get; set; }

        
        public Ship(int row, int rowlength, int rowwidth)
        {
            this.RowNumber = row;
            this.MaxRowLength = rowlength;
            this.MaxRowWidth = rowwidth;
            Layout = new List<Row>();
        }

        public bool CanAddRow(int row)
        {
            return Layout.Count + row <= MaxRowLength;
        }

        public void AddRows(List<Row> rows)
        {
            if (Layout == null)
            {
                Layout = new List<Row>();
            }

            if (CanAddRow(rows.Count))
            {
                Layout.AddRange(rows);
            }
            else
            {
                throw new Exception("Can't add more rows to the ship");
            }
        }

        public void DisplayShipInfo()
        {
           var sortedRows = Layout.OrderBy(row => RowNumber);

            foreach (var row in sortedRows)
            {
                foreach (var stack in row.ShipRow)
                {
                    foreach (var container in stack.StackedContainers)
                    {
                        Console.WriteLine($"Row: {RowNumber} | Container Type: {container.Type}");
                    }
                }
            }
        }


    }
}
