using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory1
{
	public class TechEquipment:InventoryItem
	{
		public bool Batteries { get; set; }
		public TechEquipment(Guid serialNumber, string description, DateTime dateOfPurchase, int warrantyInMonths,
			double priceWhenBought, Manufacturer manufacturer, bool batteries):base ( serialNumber,description,dateOfPurchase,warrantyInMonths,
			priceWhenBought,manufacturer)
		{
			Batteries = batteries;
		}

		public double NewPrice()
		{
			var newPrice= PriceWhenBought;
			var localDate = DateTime.Now;
			TimeSpan purchaseLocalSpan = localDate - DateOfPurchase;
			var daysPurchaseLocalSpan = purchaseLocalSpan.Days;
			var monthsPurchaseLocalSpan = daysPurchaseLocalSpan / 30;
			while (monthsPurchaseLocalSpan > 0)
			{
				newPrice = newPrice - newPrice * 0.05;
				monthsPurchaseLocalSpan--;
			}
			if (newPrice < 0.3 * PriceWhenBought)
				newPrice = 0.3 * PriceWhenBought;
			return newPrice;
		}
	}
}
