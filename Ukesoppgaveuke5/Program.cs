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
double salePrice = shirt.CalculateSalePrice();
Console.WriteLine($"The sale price of the shirt is: {salePrice}");
Console.WriteLine();


ElectronicItem phone = new("iPhone x", 25, 799.99, "1 Year", "5 Volt");
ElectronicItem.ItemDetails(phone);
salePrice = phone.CalculateSalePrice();
Console.WriteLine($"The sale price of the phone is: {salePrice}");
Console.WriteLine();


ClothingItem jacket = new("Formal Jacket", 12, 179.99, "X-Large", "Black");
ClothingItem.ItemDetails(jacket);
salePrice = jacket.CalculateSalePrice();
Console.WriteLine($"The sale price of the formal jacket is: {salePrice}");
Console.WriteLine();


ElectronicItem tv = new("Samsung 72 inch TV", 32, 1299.99, "5 Years", "230 Volt");
ElectronicItem.ItemDetails(tv);
salePrice = tv.CalculateSalePrice();
Console.WriteLine($"The sale price of the TV is: {salePrice}");
Console.WriteLine();