using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Inventory1
{
	class Program
	{
		static void Main(string[] args)
		{
			var mobilePhoneList = mobilePhoneListGenerator();
			var vehicleList = vehicleListGenerator();
			var personalComputerList = personalComputerListGenerator();
			int menuNumber;
			do
			{
				menu();
				menuNumber = int.Parse(Console.ReadLine());
				if (menuNumber == 1)
				{
					Console.WriteLine("Type 'delete' if you want to delete personal computer");
					Console.WriteLine("Type 'add' if you want to add personal computer");
					var addOrDelete = Console.ReadLine();
					if (addOrDelete == "add")
					{
						Console.WriteLine("Type serial number");
						var serialNumberGuid = Guid.Parse(Console.ReadLine());
						Console.WriteLine("Type description");
						var description = Console.ReadLine();
						Console.WriteLine("Type year of purchase");
						var year = int.Parse(Console.ReadLine());
						Console.WriteLine("Type month of purchase");
						var month = int.Parse(Console.ReadLine());
						Console.WriteLine("Type day of purchase");
						var day = int.Parse(Console.ReadLine());
						var dateOfPurchase = new DateTime(year, month, day);
						Console.WriteLine("Type remaining warranty in months");
						var warrantyMonths = int.Parse(Console.ReadLine());
						Console.WriteLine("Type buying price");
						var price = double.Parse(Console.ReadLine());
						Console.WriteLine("Type manufacturer");
						var manufacturer = Console.ReadLine();
						Console.WriteLine("Do this computer have batteries, type true if yes, type false if no");
						bool batteries = bool.Parse(Console.ReadLine());
						Console.WriteLine("Type operating system of pc");
						var operatingSystem = Console.ReadLine();
						Console.WriteLine("Is this PC portable? if yes type true, if no type false");
						bool portable = bool.Parse(Console.ReadLine());
						var personalComputer = new PersonalComputer(serialNumberGuid, description, dateOfPurchase,
							warrantyMonths,
							price, manufacturer, batteries, operatingSystem, portable);
						personalComputerList.Add(personalComputer);
					}
					else if (addOrDelete == "delete")
					{
						for (int i = 0; i < personalComputerList.Count; i++)
						{
							Console.WriteLine(
								$"{i + 1}" + "\n" + $"serial number: {personalComputerList[i].SerialNumber}" + "\n" +
								$"description: {personalComputerList[i].Description}" + "\n" +
								$"date of purchase: {personalComputerList[i].DateOfPurchase} " + "\n" +
								$"remaining warranty: {personalComputerList[i].WarrantyInMonths}" + "\n" +
								$"buying price: {personalComputerList[i].PriceWhenBought} " + "\n" +
								$"manufacturer: {personalComputerList[i].Manufacturer}" + "\n" +
								$"batteries : {personalComputerList[i].Batteries}" + "\n" +
								$"operating system : {personalComputerList[i].OperatingSystem}" + "\n" +
								$"portable: {personalComputerList[i].Portable}");
						}

						Console.WriteLine("Type ordinal number that represents PC which you want to delete");
						var listOrdinalNumber = int.Parse(Console.ReadLine());
						if (listOrdinalNumber > personalComputerList.Count + 1)
						{
							Console.WriteLine("That ordinal number doesnt exist");
						}
						else
						{
							personalComputerList.RemoveAt(listOrdinalNumber - 1);
							Console.WriteLine("Personal Computer Deleted ");
						}
					}

					else
						Console.WriteLine("Wrong command");
				}
				else if (menuNumber == 2)
				{
					Console.WriteLine("Type 'delete' if you want to delete mobile phone");
					Console.WriteLine("Type 'add' if you want to add mobile phone");
					var addOrDelete = Console.ReadLine();
					if (addOrDelete == "add")
					{
						Console.WriteLine("Type serial number");
						var serialNumberGuid = Guid.Parse(Console.ReadLine());
						Console.WriteLine("Type description");
						var description = Console.ReadLine();
						Console.WriteLine("Type year of purchase");
						var year = int.Parse(Console.ReadLine());
						Console.WriteLine("Type month of purchase");
						var month = int.Parse(Console.ReadLine());
						Console.WriteLine("Type day of purchase");
						var day = int.Parse(Console.ReadLine());
						var dateOfPurchase = new DateTime(year, month, day);
						Console.WriteLine("Type remaining warranty in months");
						var warrantyMonths = int.Parse(Console.ReadLine());
						Console.WriteLine("Type buying price");
						var price = double.Parse(Console.ReadLine());
						Console.WriteLine("Type manufacturer");
						var manufacturer = Console.ReadLine();
						Console.WriteLine("Does this mobile phone have batteries, type true if yes, type false if no");
						bool batteries = bool.Parse(Console.ReadLine());
						Console.WriteLine("Type mobile number");
						var mobileNumber = Console.ReadLine();
						Console.WriteLine("Type owner's name");
						var ownerName = Console.ReadLine();
						var mobilePhone = new MobilePhone(serialNumberGuid, description, dateOfPurchase,
							warrantyMonths,
							price, manufacturer, batteries, mobileNumber, ownerName);
						mobilePhoneList.Add(mobilePhone);
					}
					else if (addOrDelete == "delete")
					{
						for (int i = 0; i < mobilePhoneList.Count; i++)
						{
							Console.WriteLine(
								$"{i + 1}" + "\n" + $"serial number: {mobilePhoneList[i].SerialNumber}" + "\n" +
								$"description: {mobilePhoneList[i].Description}" + "\n" +
								$"date of purchase: {mobilePhoneList[i].DateOfPurchase} " + "\n" +
								$"remaining warranty: {mobilePhoneList[i].WarrantyInMonths}" + "\n" +
								$"buying price: {mobilePhoneList[i].PriceWhenBought} " + "\n" +
								$"manufacturer: {mobilePhoneList[i].Manufacturer}" + "\n" +
								$"batteries : {mobilePhoneList[i].Batteries}" + "\n" +
								$"mobile phone number : {mobilePhoneList[i].MobileNumber}" + "\n" +
								$"owner's name: {mobilePhoneList[i].OwnerName}");
						}

						Console.WriteLine("Type ordinal number that represents mobile phone which you want to delete");
						var listOrdinalNumber = int.Parse(Console.ReadLine());
						if (listOrdinalNumber > mobilePhoneList.Count + 1)
						{
							Console.WriteLine("That ordinal number doesnt exist");
						}
						else
						{
							mobilePhoneList.RemoveAt(listOrdinalNumber - 1);
							Console.WriteLine("Mobile phone deleted.");
						}
					}
				}
				else if (menuNumber == 3)
				{
					Console.WriteLine("Type 'delete' if you want to vehicle");
					Console.WriteLine("Type 'add' if you want to add vehicle");
					var addOrDelete = Console.ReadLine();
					if (addOrDelete == "add")
					{
						Console.WriteLine("Type serial number");
						var serialNumberGuid = Guid.Parse(Console.ReadLine());
						Console.WriteLine("Type description");
						var description = Console.ReadLine();
						Console.WriteLine("Type year of purchase");
						var year = int.Parse(Console.ReadLine());
						Console.WriteLine("Type month of purchase");
						var month = int.Parse(Console.ReadLine());
						Console.WriteLine("Type day of purchase");
						var day = int.Parse(Console.ReadLine());
						var dateOfPurchase = new DateTime(year, month, day);
						Console.WriteLine("Type remaining warranty in months");
						var warrantyMonths = int.Parse(Console.ReadLine());
						Console.WriteLine("Type buying price");
						var price = double.Parse(Console.ReadLine());
						Console.WriteLine("Type manufacturer");
						var manufacturer = Console.ReadLine();
						Console.WriteLine("Type year of registration expire date");
						var regYear = int.Parse(Console.ReadLine());
						Console.WriteLine("Type month of registration expire date");
						var regMonth = int.Parse(Console.ReadLine());
						Console.WriteLine("Type day of registration expire date");
						var regDay = int.Parse(Console.ReadLine());
						var registrationExpireDate = new DateTime(regYear, regMonth, regDay);
						Console.WriteLine("Type kilometres passed with vehicle");
						var kilometresPassed = double.Parse(Console.ReadLine());
						var vehicle = new Vehicle(serialNumberGuid, description, dateOfPurchase,
							warrantyMonths,
							price, manufacturer, registrationExpireDate, kilometresPassed);
						vehicleList.Add(vehicle);
					}
					else if (addOrDelete == "delete")
					{
						for (int i = 0; i < vehicleList.Count; i++)
						{
							Console.WriteLine(
								$"{i + 1}" + "\n" + $"serial number: {vehicleList[i].SerialNumber}" + "\n" +
								$"description: {vehicleList[i].Description}" + "\n" +
								$"date of purchase: {vehicleList[i].DateOfPurchase} " + "\n" +
								$"remaining warranty: {vehicleList[i].WarrantyInMonths}" + "\n" +
								$"buying price: {vehicleList[i].PriceWhenBought} " + "\n" +
								$"manufacturer: {vehicleList[i].Manufacturer}" + "\n" +
								$"registration expire date : {vehicleList[i].RegistrationExpireDate}" + "\n" +
								$"kilometres passed: {vehicleList[i].KilometresPassed}");
						}

						Console.WriteLine("Type ordinal number that represents vehicle which you want to delete");
						var listOrdinalNumber = int.Parse(Console.ReadLine());
						if (listOrdinalNumber > vehicleList.Count + 1)
						{
							Console.WriteLine("That ordinal number doesnt exist");
						}
						else
						{
							vehicleList.RemoveAt(listOrdinalNumber - 1);
							Console.WriteLine("vehicle deleted.");
						}
					}
				}
				else if (menuNumber == 4)
				{
					Console.WriteLine("Type serial number of desired inventory item");
					var serialNumberSearch = Guid.Parse(Console.ReadLine());
					for (int i = 0; i < personalComputerList.Count; i++)
					{
						if (serialNumberSearch == personalComputerList[i].SerialNumber)
						{
							Console.WriteLine(
								$"serial number: {personalComputerList[i].SerialNumber}" + "\n" +
								$"description: {personalComputerList[i].Description}" + "\n" +
								$"date of purchase: {personalComputerList[i].DateOfPurchase} " + "\n" +
								$"remaining warranty: {personalComputerList[i].WarrantyInMonths}" + "\n" +
								$"buying price: {personalComputerList[i].PriceWhenBought} " + "\n" +
								$"manufacturer: {personalComputerList[i].Manufacturer}" + "\n" +
								$"batteries : {personalComputerList[i].Batteries}" + "\n" +
								$"operating system : {personalComputerList[i].OperatingSystem}" + "\n" +
								$"portable: {personalComputerList[i].Portable}");
						}
					}
					for (int i = 0; i < mobilePhoneList.Count; i++)
					{
						if (serialNumberSearch == mobilePhoneList[i].SerialNumber)
						{
							Console.WriteLine(
								$"serial number: {mobilePhoneList[i].SerialNumber}" + "\n" +
								$"description: {mobilePhoneList[i].Description}" + "\n" +
								$"date of purchase: {mobilePhoneList[i].DateOfPurchase} " + "\n" +
								$"remaining warranty: {mobilePhoneList[i].WarrantyInMonths}" + "\n" +
								$"buying price: {mobilePhoneList[i].PriceWhenBought} " + "\n" +
								$"manufacturer: {mobilePhoneList[i].Manufacturer}" + "\n" +
								$"batteries : {mobilePhoneList[i].Batteries}" + "\n" +
								$"mobile phone number : {mobilePhoneList[i].MobileNumber}" + "\n" +
								$"owner's name: {mobilePhoneList[i].OwnerName}");
						}
					}
					for (int i = 0; i < vehicleList.Count; i++)
					{
						if (serialNumberSearch == vehicleList[i].SerialNumber)
						{
							Console.WriteLine(
								$"serial number: {vehicleList[i].SerialNumber}" + "\n" +
								$"description: {vehicleList[i].Description}" + "\n" +
								$"date of purchase: {vehicleList[i].DateOfPurchase} " + "\n" +
								$"remaining warranty: {vehicleList[i].WarrantyInMonths}" + "\n" +
								$"buying price: {vehicleList[i].PriceWhenBought} " + "\n" +
								$"manufacturer: {vehicleList[i].Manufacturer}" + "\n" +
								$"registration expire date : {vehicleList[i].RegistrationExpireDate}" + "\n" +
								$"kilometres passed: {vehicleList[i].KilometresPassed}");
						}
					}
				}
				else if (menuNumber == 5)
				{
					Console.WriteLine("Type in year to find out which PC's warranty expires that year");
					var searchYear = int.Parse(Console.ReadLine());
					var YearDate = new DateTime(searchYear, 1, 1);
					for (int i = 0; i < personalComputerList.Count; i++)
					{
						if (personalComputerList[i].DateOfPurchase
							    .AddMonths(personalComputerList[i].WarrantyInMonths).Year == YearDate.Year)
						{
							Console.WriteLine(
								$"serial number: {personalComputerList[i].SerialNumber}" + "\n" +
								$"description: {personalComputerList[i].Description}" + "\n" +
								$"date of purchase: {personalComputerList[i].DateOfPurchase} " + "\n" +
								$"remaining warranty: {personalComputerList[i].WarrantyInMonths}" + "\n" +
								$"buying price: {personalComputerList[i].PriceWhenBought} " + "\n" +
								$"manufacturer: {personalComputerList[i].Manufacturer}" + "\n" +
								$"batteries : {personalComputerList[i].Batteries}" + "\n" +
								$"operating system : {personalComputerList[i].OperatingSystem}" + "\n" +
								$"portable: {personalComputerList[i].Portable}");
						}
					}
				}
				else if (menuNumber == 6)
				{
					int batteriesCount = 0;
					for (int i = 0; i < personalComputerList.Count; i++)
					{
						if(personalComputerList[i].Batteries==true)
						batteriesCount++;
					}
					for (int i = 0; i < mobilePhoneList.Count; i++)
					{
						if (mobilePhoneList[i].Batteries == true)
							batteriesCount++;
					}
					Console.WriteLine($"there are {batteriesCount} of tech equipment with batteries");
				}
			}
			while (menuNumber >= 1 && menuNumber <= 10);
			Console.WriteLine("End program");
		}
		public static List<MobilePhone> mobilePhoneListGenerator()
		{
			var mobilePhoneList = new List<MobilePhone>();
			var mobilePhone1Date = new DateTime(2007, 12, 1);
			var mobilePhone2Date = new DateTime(2009, 1, 23);
			var mobilePhone1 = new MobilePhone(Guid.NewGuid(), "White model with new gorilla glass",
				mobilePhone1Date, 20, 3020.123, "Samsung", false, "0958157124", "ivo sivo");
			var mobilePhone2 = new MobilePhone(Guid.NewGuid(), "Old used phone", mobilePhone2Date, 2, 123, "Alcatel",
				false,
				"091234234", "Vojko Vrucina");
			mobilePhoneList.Add(mobilePhone1);
			mobilePhoneList.Add(mobilePhone2);
			return mobilePhoneList;
		}

		public static List<Vehicle> vehicleListGenerator()
		{
			var vehicleList = new List<Vehicle>();
			var vehicle1DateOfPurchase = new DateTime(2000, 1, 1);
			var vehicle1DateOfRegExpire = new DateTime(2015, 12, 1);
			var vehicle2DateOfPurchase = new DateTime(1965, 11, 8);
			var vehicle2DateOfRegExpire = new DateTime(2012, 6, 19);
			var vehicle1 = new Vehicle(Guid.NewGuid(), "Metallic black car with blue neons", vehicle1DateOfPurchase, 1,
				100000, "Ferrari",
				vehicle2DateOfRegExpire, 525000);
			var vehicle2 = new Vehicle(Guid.NewGuid(), "Gray timemachine with fancy doors", vehicle2DateOfPurchase, 52,
				123456789,
				"DeLorean", vehicle2DateOfRegExpire, 5788000);
			vehicleList.Add(vehicle1);
			vehicleList.Add(vehicle2);
			return vehicleList;
		}
		public static List<PersonalComputer> personalComputerListGenerator()
		{
			var personalComputerList = new List<PersonalComputer>();
			var personalComputer1Date = new DateTime(2005, 7, 4);
			var personalComputer2Date = new DateTime(2009, 11, 6);
			var personalComputer1 = new PersonalComputer(Guid.NewGuid(), "Made of premium plastic",
				personalComputer1Date, 24, 15000,
				"Asus", true, "Linux", true);
			var personalComputer2 = new PersonalComputer(Guid.NewGuid(), "Brand new watercooling housing system",
				personalComputer2Date,
				12, 11132.123, "Intel", true, "Windows", false);
			personalComputerList.Add(personalComputer1);
			personalComputerList.Add(personalComputer2);
			return personalComputerList;
		}
		public static void menu()
		{
			Console.WriteLine(" ");
			Console.WriteLine("Read carefully what do you want to do in menu. When you choose the action, " +
			                  " type in ordinal number which represents wanted action");
			Console.WriteLine("1. Delete or add new personal computer ");
			Console.WriteLine("2. Delete or add new Mobile phone ");
			Console.WriteLine("3. Delete or add new vehicle ");
			Console.WriteLine(
				"4. Search through whole inventory with desired product serial number and get product info");
			Console.WriteLine("5. Search trough personal computer inventory with desired warranty expire year");
			Console.WriteLine("6. Search how many tech equipment have batteries");
			Console.WriteLine("7. Search through mobile phone inventory with desired mobilephone brand ");
			Console.WriteLine("8. Search through personal computer inventory with desired operating system");
			Console.WriteLine("9. Search through mobile phone inventory with desired warranty expire year");
			Console.WriteLine("10. Print all vehicles which registration expires in next month");
		}
	}
}
	

