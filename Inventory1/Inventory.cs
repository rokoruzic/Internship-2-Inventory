using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Inventory1
{
	public class Inventory
	{
		public Guid SerialNumber { get; set; }
		public string Description { get; set; }
		public DateTime DateOfPurchase { get; set; }
		public int WarrantyInMonths { get; set; }
		public double PriceWhenBought { get; set; }
		public string Manufacturer { get; set; }
		public Inventory(Guid serialNumber, string description, DateTime dateOfPurchase, int warrantyInMonths,
			double priceWhenBought, string manufacturer)
		{
			SerialNumber = serialNumber;
			Description = description;
			DateOfPurchase = dateOfPurchase;
			WarrantyInMonths = warrantyInMonths;
			PriceWhenBought = priceWhenBought;
			Manufacturer = manufacturer;
		}
	}
}
