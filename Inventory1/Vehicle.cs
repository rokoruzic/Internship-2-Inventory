using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Inventory1
{
	public class Vehicle
	{
		public Guid SerialNumber { get; set; }
		public string Description { get; set; }
		public DateTime DateOfPurchase { get; set; }
		public int WarrantyInMonths { get; set; }
		public double PriceWhenBought { get; set; }
		public string Manufacturer { get; set; }
		public double KilometresPassed { get; set; }
		public DateTime RegistrationExpireDate { get; set; }

		public Vehicle(Guid serialNumber, string description, DateTime dateOfPurchase,
			int warrantyInMonths, double priceWhenBought, string manufacturer,
			DateTime registrationExpireDate, double kilometresPassed)

		{
			SerialNumber = serialNumber;
			Description = description;
			DateOfPurchase = dateOfPurchase;
			WarrantyInMonths = warrantyInMonths;
			PriceWhenBought = priceWhenBought;
			Manufacturer = manufacturer;
			KilometresPassed = kilometresPassed;
			RegistrationExpireDate = registrationExpireDate;
		}
	}
}
