using System;
using System.Linq;

namespace ACM.BL
{
	public class CustomerRepository
	{
		public CustomerRepository()
		{
			addressRepository = new AddressRepository();
		}
		private static AddressRepository addressRepository { get; set; }
		/// <summary>
		/// Retrieve one customer.
		/// </summary>
		/// 
		public static Customer Retrieve(int customerId)
		{
			// Create the instance of the Customer class
			// Pass in the requested id
			Customer customer = new(customerId);

			// Code that retrieves the defined customer

			// Temporary hard-coded values to return
			// a populated customer
			if (customerId == 1)
			{
				customer.EmailAddress = "fbaggins@hobbiton.me";
				customer.FirstName = "Frodo";
				customer.LastName = "Baggins";
				customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
			}
			return customer;
		}

		/// <summary>
		/// Saves the current customer.
		/// </summary>
		/// 
		public static bool Save(Customer customer)
		{
			var success = true;

			if (customer.HasChanges)
			{
				if (customer.IsValid)
				{
					if (customer.IsNew)
					{
						// Call an Insert Stored Procedure
					}
					else
					{
						// Call an Update Stored Procedure
					}
				}
				else
				{
					success = false;
				}
			}
			return success;
		}
	}
}
