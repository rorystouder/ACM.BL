﻿namespace ACM.BL
{
	public class CustomerRepository
	{
		/// <summary>
		/// Retrieve one customer.
		/// </summary>
		/// 
		public Customer Retrieve(int customerId)
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
			}
			return customer;
		}

		/// <summary>
		/// Saves the current customer.
		/// </summary>
		/// 
		public bool Save(Customer customer)
		{
			// Code that saves the passed in customer

			return true;
		}
	}
}
