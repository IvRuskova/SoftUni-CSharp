namespace _06.StoreBoxes
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            List<Box> boxes = new List<Box>();
            while (data[0] != "end")
            {
                string itemName = data[1];
                decimal itemPrice = decimal.Parse(data[3]);

                int serialNumber = int.Parse(data[0]);
                int itemQuantity = int.Parse(data[2]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, itemQuantity, itemPrice,item);

                boxes.Add(box);
                data = Console.ReadLine().Split();
            }

            boxes = boxes.OrderByDescending(b => b.PriceBox).ToList();
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- { box.Item.Name} - ${ box.Item.Price:f2}: { box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }
    }
}
