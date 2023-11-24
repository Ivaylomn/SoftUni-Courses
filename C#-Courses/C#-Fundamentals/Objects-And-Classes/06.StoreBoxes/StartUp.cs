namespace _06.StoreBoxes
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commadnArgs = command.Split();

                int serialNumber = int.Parse(commadnArgs[0]);
                string itemName = commadnArgs[1];
                int itemQuantity = int.Parse(commadnArgs[2]);
                decimal itemPrice = decimal.Parse(commadnArgs[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemQuantity = itemQuantity,
                    Item = item
                };

                boxes.Add(box);

                command = Console.ReadLine();
            }

            foreach (Box box in boxes.OrderByDescending(x => x.Price))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }
}
    


