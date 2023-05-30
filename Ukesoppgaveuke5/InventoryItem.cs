namespace Ukesoppgaveuke5
{
    internal class InventoryItem
    {
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public double Price { get; private set; }


        public InventoryItem(string itemName, int itemAmount, double itemPrice)
        {
            Name = itemName;
            Amount = itemAmount;
            Price = itemPrice;
        }
    }
}