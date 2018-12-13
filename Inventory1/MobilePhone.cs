using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory1
{
	public class MobilePhone : TechEquipment
	{
		public string MobileNumber { get; set; }
		public string OwnerName { get; set; }
		public MobilePhone(Guid serialNumber, string description, DateTime dateOfPurchase, int warrantyInMonths,
			double priceWhenBought, Manufacturer manufacturer, bool batteries, string mobileNumber, string ownerName)
			: base(serialNumber, description,
				dateOfPurchase,
				warrantyInMonths, priceWhenBought, manufacturer, batteries)
		{
			MobileNumber = mobileNumber;
			OwnerName = ownerName;
		}
	}
}
