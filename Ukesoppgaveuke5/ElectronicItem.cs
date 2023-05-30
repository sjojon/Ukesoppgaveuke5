using System.Threading.Channels;

namespace Ukesoppgaveuke5
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public string InsuranceInformation { get; private set; }
        public string Voltage { get; private set; }

        public ElectronicItem(string itemName, int itemAmount, double itemPrice, string insurance, string voltage)
            : base(itemName, itemAmount, itemPrice)
        {
            InsuranceInformation = insurance;
            Voltage = voltage;
        }

        public double CalculateSalePrice()
        {
            double salePrice = Price * 1.25;
            return salePrice;
        }

        //public static void ListItems(List<ElectronicItem> electronicItem)
        //{
        //    foreach (var items in electronicItem)
        //    {
        //        ItemDetails(items);
        //    }
        //}

        public static void ItemDetails(ElectronicItem electronicItem)
        {
            Console.WriteLine(
                $"Item: {electronicItem.Name}\nAmount: {electronicItem.Amount}\nPrice: {electronicItem.Price}$\nInsurance: {electronicItem.InsuranceInformation}\nVoltage: {electronicItem.Voltage}");
            Console.WriteLine();
        }
    }
}