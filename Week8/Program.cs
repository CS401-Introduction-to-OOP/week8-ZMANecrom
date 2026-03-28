using Week8;

Letter letter1 = new Letter("1", 0.5);
Letter letter2 = new Letter("2", 1.4);
Parcel parcel1 = new Parcel("3", 7, "35x24x13");
Parcel parcel2 = new Parcel("4", 11, "91x76x43");

letter1.PrintInfo();
parcel2.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
myCargo.AddItem(letter1);
myCargo.AddItem(letter2);
myCargo.AddItem(parcel1);
myCargo.AddItem(parcel2);

Console.WriteLine(myCargo.GetTotalCost());