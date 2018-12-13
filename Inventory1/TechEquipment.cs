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
	}
}
