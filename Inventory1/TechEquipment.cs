using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory1
{
	public class TechEquipment
	{
		public Guid SerialNumber { get; set; }
		public string Description { get; set; }
		public DateTime DateOfPurchase { get; set; }
		public int WarrantyInMonths { get; set; }
		public double PriceWhenBought { get; set; }
		public string Manufacturer { get; set; }
		public bool Batteries { get; set; }


		public TechEquipment(Guid serialNumber, string description, DateTime dateOfPurchase, int warrantyInMonths,
			double priceWhenBought, string manufacturer, bool batteries)
		{
			SerialNumber = serialNumber;
			Description = description;
			DateOfPurchase = dateOfPurchase;
			WarrantyInMonths = warrantyInMonths;
			PriceWhenBought = priceWhenBought;
			Manufacturer = manufacturer;
			Batteries = batteries;
		}



	}
}
