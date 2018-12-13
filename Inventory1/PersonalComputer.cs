using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory1
{
	public class PersonalComputer : TechEquipment
	{
		public  OperatingSystem OperatingSystem { get; set; }
		public bool Portable { get; set; }
		public PersonalComputer(Guid serialNumber, string description, DateTime dateOfPurchase, int warrantyInMonths,
			double priceWhenBought, Manufacturer manufacturer, bool batteries, OperatingSystem operatingSystem, bool portable)
			: base(serialNumber, description, dateOfPurchase, warrantyInMonths, priceWhenBought, manufacturer,
				batteries)
		{
			OperatingSystem = operatingSystem;
			Portable = portable;
		}
	}
}