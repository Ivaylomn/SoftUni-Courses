namespace _06.StoreBoxes
{
    internal class Box
    {
        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal Price 
            => ItemQuantity * Item.Price;
    }
}
