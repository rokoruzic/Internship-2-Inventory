using System;
using System.Collections.Generic;

namespace Inventory1
{
	class Program
	{
		static void Main(string[] args)
		{
			var mobilePhoneList= mobilePhoneListGenerator();
			var vehicleList = vehicleListGenerator();
			var personalComputerList = personalComputerListGenerator();
			menu();



		}
		public static List<MobilePhone> mobilePhoneListGenerator()
		{
			var mobilePhoneList = new List<MobilePhone>();
			var mobilePhone1Date = new DateTime(2007, 12, 1);
			var mobilePhone2Date = new DateTime(2009, 1, 23);
			var mobilePhone1 = new MobilePhone(Guid.NewGuid(), "White model with new gorilla glass",
				mobilePhone1Date, 20, 3020.123, "Samsung", true, "0958157124", "ivo sivo");
			var mobilePhone2= new MobilePhone(Guid.NewGuid(),"Old used phone",mobilePhone2Date,2,123,"Alcatel",true,
				"091234234","Vojko Vrucina");
			mobilePhoneList.Add(mobilePhone1);
			mobilePhoneList.Add(mobilePhone2);
			return mobilePhoneList;
		}
		public static List<Vehicle> vehicleListGenerator()
		{
			var vehicleList = new List<Vehicle>();
			var vehicle1DateOfPurchase = new DateTime(2000,1,1);
			var vehicle1DateOfRegExpire= new DateTime(2015,12,1);
			var vehicle2DateOfPurchase = new DateTime(1965,11,8);
			var vehicle2DateOfRegExpire = new DateTime(2012, 6, 19);
			var vehicle1 = new Vehicle(Guid.NewGuid(),"Metallic black car with blue neons",vehicle1DateOfPurchase,1,100000,"Ferrari",
				vehicle2DateOfRegExpire,525000);
			var vehicle2 = new Vehicle(Guid.NewGuid(), "Gray timemachine with fancy doors",vehicle2DateOfPurchase,52,123456789,
				"DeLorean",vehicle2DateOfRegExpire,5788000);
			vehicleList.Add(vehicle1);
			vehicleList.Add(vehicle2);
			return vehicleList;
		}

		public static List<PersonalComputer> personalComputerListGenerator()
		{
			var personalComputerList = new List<PersonalComputer>();
			var personalComputer1Date= new DateTime(2005,7,4);
			var personalComputer2Date= new DateTime(2009,11,6);
			var personalComputer1 = new PersonalComputer(Guid.NewGuid(),"Made of premium plastic",personalComputer1Date,30,15000,
				"Asus",true,"Linux",true);
			var personalComputer2 = new PersonalComputer(Guid.NewGuid(),"Brand new watercooling housing system",personalComputer2Date,
				12,11132.123,"Intel",false,"Windows",false);
			personalComputerList.Add(personalComputer1);
			personalComputerList.Add(personalComputer2);
			return personalComputerList;
		}

		public static void menu()
		{
			Console.WriteLine("Read carefully what do you want to do in menu. When you choose the action, " +
			                  " type in ordinal number which represents wanted action");
			Console.WriteLine("1. Delete or add new personal computer ");
			Console.WriteLine("2. Delete or add new Mobile phone ");
			Console.WriteLine("3. Delete or add new vehicle ");
			Console.WriteLine("4. Search through whole inventory with desired product serial number and get product info");
			Console.WriteLine("5. Search trough personal computer inventory with desired warranty expire year");
			Console.WriteLine("6. Search how many tech equipment have batteries");
			Console.WriteLine("7. Search through mobile phone inventory with desired mobilephone brand ");
			Console.WriteLine("8. Search through personal computer inventory with desired operating system");
			Console.WriteLine("9. Search through mobile phone inventory with desired warranty expire year");
			Console.WriteLine("10. Print all vehicles which registration expires in next month");
			
		}
	}
	


	
}
