using System.Diagnostics;

namespace Ukesoppgaveuke5
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public string Size { get; private set; }
        public string Color { get; private set; }

        public ClothingItem(string itemName, int itemAmount, double itemPrice, string itemSize, string itemColor)
            : base(itemName, itemAmount, itemPrice)
        {
            Size = itemSize;
            Color = itemColor;
        }

        public double CalculateSalePrice()
        {
            double salePrice = Price * 1.25;
            return salePrice;
        }

        //public static void ListItems(List<ClothingItem> clothingItem)
        //{
        //    foreach (var items in clothingItem)
        //    {
        //        ItemDetails(items);
        //    }
        //}

        public static void ItemDetails(ClothingItem clothingItem)
        {
            Console.WriteLine(
                $"Item: {clothingItem.Name}\nAmount: {clothingItem.Amount}\nPrice: {clothingItem.Price}$\nSize: {clothingItem.Size}\nColor: {clothingItem.Color}");
        }
    }
}