using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory1
{
	public class TechEquipment:Inventory
	{
		public bool Batteries { get; set; }
		public TechEquipment(Guid serialNumber, string description, DateTime dateOfPurchase, int warrantyInMonths,
			double priceWhenBought, string manufacturer, bool batteries):base ( serialNumber,description,dateOfPurchase,warrantyInMonths,
			priceWhenBought,manufacturer)
		{
			Batteries = batteries;
		}
	}
}
