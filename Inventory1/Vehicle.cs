using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Inventory1
{
	public class Vehicle:InventoryItem
	{
		public double KilometresPassed { get; set; }
		public DateTime RegistrationExpireDate { get; set; }
		public Vehicle(Guid serialNumber, string description, DateTime dateOfPurchase,
			int warrantyInMonths, double priceWhenBought, Manufacturer manufacturer,
			DateTime registrationExpireDate, double kilometresPassed) : base ( serialNumber,description,dateOfPurchase,
			warrantyInMonths,priceWhenBought,manufacturer)
		{
			KilometresPassed = kilometresPassed;
			RegistrationExpireDate = registrationExpireDate;
		}

		public  double NewPrice()
		{
			var limitPassedTimes = (int)(KilometresPassed / 20000);
			var newPrice = PriceWhenBought;
			
			while ( limitPassedTimes >0)
			{
			newPrice = newPrice - ( 0.1 *newPrice);
				limitPassedTimes--;
			}
			if (newPrice < 0.2 * PriceWhenBought)
				newPrice = 0.2 * PriceWhenBought;
			return newPrice;
		}
	}
}
