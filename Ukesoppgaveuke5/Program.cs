using Ukesoppgaveuke5;

//List<ElectronicItem> electronicItem = new()
//{
//    new ElectronicItem("Blow Dryer", 8, 49.99, "5 years", "230 Volt"),
//    new ElectronicItem("Laptop", 5, 399, "2 Years", "230 Volt"),
//    new ElectronicItem("GameBoy", 3, 149.99, "2 Years", "230 Volt"),
//};
//ElectronicItem.ListItems(electronicItem);

//List<ClothingItem> clothingItem = new()
//{
//    new ClothingItem("Formal Shirt", 32, 69.99, "X-Large", "White"),
//    new ClothingItem("Jacket", 30, 149.99, "Large", "Black"),
//    new ClothingItem("Pant", 25, 129.99, "Medium", "Black"),
//};
//ClothingItem.ListItems(clothingItem);

ClothingItem shirt = new("Men's T-Shirt", 50, 19.99, "Large", "Blue");
ClothingItem.ItemDetails(shirt);
//Console.WriteLine(shirt.CalculateSalePrice());
double salePrice = shirt.CalculateSalePrice();
Console.WriteLine($"The sale price of the shirt is: {salePrice}");
Console.WriteLine();

ElectronicItem phone = new("iPhone x", 25, 799.99, "1 Year", "5 Volt");
ElectronicItem.ItemDetails(phone);
//Console.WriteLine(phone.CalculateSalePrice());
salePrice = phone.CalculateSalePrice();
Console.WriteLine($"The sale price of the phone is: {salePrice}");