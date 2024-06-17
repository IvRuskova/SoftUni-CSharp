using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StoreBoxes
{
    internal class Box
    {
        public Box(int serialNumber, int itemQuantity, decimal priceBox,Item item) 
        {
            SerialNumber = serialNumber;
            ItemQuantity = itemQuantity;
            PriceBox = priceBox;
            Item =  item;
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceBox { get; set; }
    }
}
