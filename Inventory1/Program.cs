﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Security;

namespace Inventory1
{
	class Program
	{
		static void Main(string[] args)
		{
			var mobilePhoneList = MobilePhoneListGenerator();
			var vehicleList = VehicleListGenerator();
			var personalComputerList = PersonalComputerListGenerator();
			int menuNumber;
			do
			{
				Menu();
				menuNumber = int.Parse(Console.ReadLine());
				switch (menuNumber)
				{
					case 1:
					{
							var serialNumberGuid = new Guid();
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
							Console.WriteLine("Select manufacturer by typing ordinal number which represents it");
							Console.WriteLine($"{(int)Manufacturer.Asus} {Manufacturer.Asus}");
							Console.WriteLine($"{(int)Manufacturer.Toshiba} {Manufacturer.Toshiba}");
							Console.WriteLine($"{(int)Manufacturer.Hp} {Manufacturer.Hp}");
							Console.WriteLine($"{(int)Manufacturer.Dell} {Manufacturer.Dell}");
							Console.WriteLine($"{(int)Manufacturer.Intel} {Manufacturer.Intel}");
							var manufacturer = int.Parse(Console.ReadLine());
							Manufacturer manufacturerPC = (Manufacturer)manufacturer;
							Console.WriteLine("Do this computer have batteries, type true if yes, type false if no");
							bool batteries = bool.Parse(Console.ReadLine());
							Console.WriteLine("Select operating system by typing ordinal number which represents it");
							Console.WriteLine($"{(int)OperatingSystem.Windows} {OperatingSystem.Windows}");
							Console.WriteLine($"{(int)OperatingSystem.Linux} {OperatingSystem.Linux}");
							Console.WriteLine($"{(int)OperatingSystem.MacOS} {OperatingSystem.MacOS}");
							var operatingSystem = int.Parse(Console.ReadLine());
							OperatingSystem operatingSystemPC = (OperatingSystem)operatingSystem;
							Console.WriteLine("Is this PC portable? if yes type true, if no type false");
							bool portable = bool.Parse(Console.ReadLine());
							var personalComputer = new PersonalComputer(serialNumberGuid, description, dateOfPurchase,
								warrantyMonths,
								price, manufacturerPC, batteries, operatingSystemPC, portable);
							personalComputerList.Add(personalComputer);
							break;
					}
					case 2:
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
							break;
					}
					case 3:
					{
						var serialNumberGuid = new Guid();
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
						Console.WriteLine("Select manufacturer by typing ordinal number which represents it");
						Console.WriteLine($"{(int)Manufacturer.Alcatel} {Manufacturer.Alcatel}");
						Console.WriteLine($"{(int)Manufacturer.Lg} {Manufacturer.Lg}");
						Console.WriteLine($"{(int)Manufacturer.Samsung} {Manufacturer.Samsung}");
						Console.WriteLine($"{(int)Manufacturer.Nokia} {Manufacturer.Nokia}");
						var manufacturer = int.Parse(Console.ReadLine());
						Manufacturer manufacturerMobilePhone = (Manufacturer)manufacturer;
						Console.WriteLine("Does this mobile phone have batteries, type true if yes, type false if no");
						bool batteries = bool.Parse(Console.ReadLine());
						Console.WriteLine("Type mobile number");
						var mobileNumber = Console.ReadLine();
						Console.WriteLine("Type owner's name");
						var ownerName = Console.ReadLine();
						var mobilePhone = new MobilePhone(serialNumberGuid, description, dateOfPurchase,
							warrantyMonths,
							price, manufacturerMobilePhone, batteries, mobileNumber, ownerName);
						mobilePhoneList.Add(mobilePhone);
							break;
					}
					case 4:
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
							break;
					}
					case 5:
					{
							var serialNumberGuid = new Guid();
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
							Console.WriteLine("Select manufacturer by typing ordinal number which represents it");
							Console.WriteLine($"{(int)Manufacturer.Ferrari} {Manufacturer.Ferrari}");
							Console.WriteLine($"{(int)Manufacturer.DeLorean} {Manufacturer.DeLorean}");
							Console.WriteLine($"{(int)Manufacturer.Renault} {Manufacturer.Renault}");
							var manufacturer = int.Parse(Console.ReadLine());
							Manufacturer manufacturerVehicle = (Manufacturer)manufacturer;
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
								price, manufacturerVehicle, registrationExpireDate, kilometresPassed);
							vehicleList.Add(vehicle);
							break;
					}
					case 6:
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
						if (listOrdinalNumber > vehicleList.Count + 1 && listOrdinalNumber != 0)
						{
							Console.WriteLine("That ordinal number doesnt exist");
						}
						else
						{
							vehicleList.RemoveAt(listOrdinalNumber - 1);
							Console.WriteLine("vehicle deleted.");
						}
							break;
					}
					case 7:
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
							break;
					}
					case 8:
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
									$"{i + 1}" + "\n" +
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
							break;
					}
					case 9:
					{
						int batteriesCount = 0;
						for (int i = 0; i < personalComputerList.Count; i++)
						{
							if (personalComputerList[i].Batteries )
								batteriesCount++;
						}
						for (int i = 0; i < mobilePhoneList.Count; i++)
						{
							if (mobilePhoneList[i].Batteries )
								batteriesCount++;
						}
						Console.WriteLine($"there are {batteriesCount} of tech equipment with batteries");
							break;
					}
					case 10:
					{
						Console.WriteLine("Type manufacturer you want to search within mobilephone base");
						Console.WriteLine(Manufacturer.Alcatel);
						Console.WriteLine(Manufacturer.Lg);
						Console.WriteLine(Manufacturer.Samsung);
						Console.WriteLine(Manufacturer.Nokia);
						var manufacterSearch = Console.ReadLine();
						string capitalFirstManufacturerSearch = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(manufacterSearch);
						Manufacturer manufacterSearchEnum = (Manufacturer)Enum.Parse(typeof(Manufacturer), capitalFirstManufacturerSearch);
						for (int i = 0; i < mobilePhoneList.Count; i++)
						{
							if (mobilePhoneList[i].Manufacturer == manufacterSearchEnum)
							{
								Console.WriteLine(
									$"{i + 1}" + "\n" +
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
							break;
					}
					case 11:
					{
						Console.WriteLine("Type operating system you want to search within PC base");
						Console.WriteLine(OperatingSystem.Windows);
						Console.WriteLine(OperatingSystem.Linux);
						Console.WriteLine(OperatingSystem.MacOS);
						var operatingSystemSearch = Console.ReadLine();
						string capitalFirstOperatingSystemSearch = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(operatingSystemSearch);
							OperatingSystem operatingSystemSearchEnum =
								(OperatingSystem)Enum.Parse(typeof(OperatingSystem), capitalFirstOperatingSystemSearch);
							for (int i = 0; i < personalComputerList.Count; i++)
							{
								if (personalComputerList[i].OperatingSystem == operatingSystemSearchEnum)
									Console.WriteLine(
										$"{i + 1}" + "\n" +
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
							break;
					}
					case 12:
					{
						Console.WriteLine("Type in year to find out which mobile phone's warranty expires that year");
						var searchYear = int.Parse(Console.ReadLine());
						var YearDate = new DateTime(searchYear, 1, 1);
						for (int i = 0; i < mobilePhoneList.Count; i++)
						{
							if (mobilePhoneList[i].DateOfPurchase
								    .AddMonths(mobilePhoneList[i].WarrantyInMonths).Year == YearDate.Year)
							{
								Console.WriteLine(
									$"{i + 1}" + "\n" +
									$"mobile phone number : {mobilePhoneList[i].MobileNumber}" + "\n" +
									$"owner's name: {mobilePhoneList[i].OwnerName}" + "\n" +
									$"price at purchase: {mobilePhoneList[i].PriceWhenBought}" + "\n" +
									$"current value : {mobilePhoneList[i].NewPrice()}" + "\n" +
									$"price difference: {mobilePhoneList[i].PriceWhenBought-mobilePhoneList[i].NewPrice()}");
							}
						}
							break;
					}
					case 13:
					{
						Console.WriteLine("Vehicles which registration licence expires next month:");
						var localDate = DateTime.Now;
						for (int i = 0; i < vehicleList.Count; i++)
						{
							if (localDate.Month == 12 && vehicleList[i].RegistrationExpireDate.Year == localDate.Year + 1
							                          &&
							                          vehicleList[i].RegistrationExpireDate.Month == 1)
							{
								Console.WriteLine(
									$"serial number: {vehicleList[i].SerialNumber}" + "\n" +
									$"description: {vehicleList[i].Description}" + "\n" +
									$"date of purchase: {vehicleList[i].DateOfPurchase} " + "\n" +
									$"remaining warranty: {vehicleList[i].WarrantyInMonths}" + "\n" +
									$"price at purchase: {vehicleList[i].PriceWhenBought}" + "\n" +
									$"current value : {vehicleList[i].NewPrice()}" + "\n" +
									$"price difference: {vehicleList[i].PriceWhenBought -vehicleList[i].NewPrice()}" + "\n" +
									$"manufacturer: {vehicleList[i].Manufacturer}" + "\n" +
									$"registration expire date : {vehicleList[i].RegistrationExpireDate}" + "\n" +
									$"kilometres passed: {vehicleList[i].KilometresPassed}");
							

							}

								else if (vehicleList[i].RegistrationExpireDate.Month == localDate.Month + 1)

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
							break;
					}
					
					default:
					{
						Console.WriteLine("End program");
						break;
					}
				}
			}
			while (menuNumber >= 1 && menuNumber <= 13);
		}
		public static List<MobilePhone> MobilePhoneListGenerator()
		{
			var mobilePhoneList = new List<MobilePhone>();
			var mobilePhone1Date = new DateTime(2007, 12, 1);
			var mobilePhone2Date = new DateTime(2018, 10, 15);
			var mobilePhone1 = new MobilePhone(Guid.NewGuid(), "White model with new gorilla glass",
				mobilePhone1Date, 20, 3020.123, Manufacturer.Samsung, false, "0958157124", "ivo sivo");
			var mobilePhone2 = new MobilePhone(Guid.NewGuid(), "Old used phone", mobilePhone2Date, 1, 100, Manufacturer.Alcatel,
				false,
				"091234234", "Vojko Vrucina");
			mobilePhoneList.Add(mobilePhone1);
			mobilePhoneList.Add(mobilePhone2);
			return mobilePhoneList;
		}

		public static List<Vehicle> VehicleListGenerator()
		{
			var vehicleList = new List<Vehicle>();
			var vehicle1DateOfPurchase = new DateTime(2000, 1, 1);
			var vehicle1DateOfRegExpire = new DateTime(2019, 1, 1);
			var vehicle2DateOfPurchase = new DateTime(1965, 11, 8);
			var vehicle2DateOfRegExpire = new DateTime(2019, 6, 19);
			var vehicle1 = new Vehicle(Guid.NewGuid(), "Metallic black car with blue neons", vehicle1DateOfPurchase, 1,
				100000, Manufacturer.Ferrari,
				vehicle1DateOfRegExpire, 20000);
			var vehicle2 = new Vehicle(Guid.NewGuid(), "Gray timemachine with fancy doors", vehicle2DateOfPurchase, 52,
				123456789,
				Manufacturer.DeLorean, vehicle2DateOfRegExpire, 5788000);
			vehicleList.Add(vehicle1);
			vehicleList.Add(vehicle2);
			return vehicleList;
		}
		public static List<PersonalComputer> PersonalComputerListGenerator()
		{
			var personalComputerList = new List<PersonalComputer>();
			var personalComputer1Date = new DateTime(2005, 7, 4);
			var personalComputer2Date = new DateTime(2009, 11, 6);
			var personalComputer1 = new PersonalComputer(Guid.NewGuid(), "Made of premium plastic",
				personalComputer1Date, 24, 15000,
				Manufacturer.Asus, true, OperatingSystem.Linux, true);
			var personalComputer2 = new PersonalComputer(Guid.NewGuid(), "Brand new watercooling housing system",
				personalComputer2Date,
				12, 11132.123, Manufacturer.Intel, true, OperatingSystem.Windows, false);
			personalComputerList.Add(personalComputer1);
			personalComputerList.Add(personalComputer2);
			return personalComputerList;
		}
		public static void Menu()
		{
			Console.WriteLine(" ");
			Console.WriteLine("Read carefully what do you want to do in menu. When you choose the action, " +
			                  " type in ordinal number which represents wanted action");
			Console.WriteLine("1. Add new personal computer");
			Console.WriteLine("2. Delete personal computer ");
			Console.WriteLine("3. Add new Mobile phone ");
			Console.WriteLine("4. Delete Mobile phone ");
			Console.WriteLine("5. Add new vehicle ");
			Console.WriteLine("6. Delete vehicle ");
			Console.WriteLine(
				"7. Search through whole inventory with desired product serial number and get product info");
			Console.WriteLine("8. Search trough personal computer inventory with desired warranty expire year");
			Console.WriteLine("9. Search how many tech equipment have batteries");
			Console.WriteLine("10. Search through mobile phone inventory with desired mobilephone brand ");
			Console.WriteLine("11. Search through personal computer inventory with desired operating system");
			Console.WriteLine("12. Search through mobile phone inventory with desired warranty expire year");
			Console.WriteLine("13. Print all vehicles which registration expires in next month");
		}
	}
}
	

