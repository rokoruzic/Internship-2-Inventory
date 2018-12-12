using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Inventory1
{
	public class Vehicle:Inventory
	{
		public double KilometresPassed { get; set; }
		public DateTime RegistrationExpireDate { get; set; }
		public Vehicle(Guid serialNumber, string description, DateTime dateOfPurchase,
			int warrantyInMonths, double priceWhenBought, string manufacturer,
			DateTime registrationExpireDate, double kilometresPassed) : base ( serialNumber,description,dateOfPurchase,
			warrantyInMonths,priceWhenBought,manufacturer)
		{
			KilometresPassed = kilometresPassed;
			RegistrationExpireDate = registrationExpireDate;
		}
	}
}
