using System;
using System.Collections.Generic;

namespace ACM.BL
{
	public class AddressRepository
	{
		///<summary>
		///Retrieve one address.
		///</summary>
		///
		public static Address Retrieve(int addressId)
		{
			// Create the instance of the Address class
			// Pass in the requested Id
			Address address = new(addressId);

			// Code that retrieves the defiened address

			// Temporary hard-coded values to return
			// a populated address
			if(addressId == 1)
			{
				address.AddressId = 1;
				address.StreetLineOne = "Bag End";
				address.StreetLineTwo = "Bagshot row";
				address.City = "Hobbiton";
				address.StateProvince = "Shire";
				address.Country = "Middle Earth";
				address.PostalCode = "144";
			}
			return address;
		}

		public IEnumerable<Address> RetrieveByCustomerId(int customerId)
		{
			// Code that retrieve the defined addresses
			// for the customer.

			// Temporary hard-coded values to return
			// a set of addresses for a customer
			var addressList = new List<Address>();
			Address address = new(1)
			{
				AddressType = 1,
				StreetLineOne = "Bag End",
				StreetLineTwo = "Bagshot row",
				City = "Hobbiton",
				StateProvince = "Shire",
				Country = "Middle Earth",
				PostalCode = "144"
			};
			addressList.Add(address);

			address = new(2)
			{
				AddressType = 2,
				StreetLineOne = "Green Dragon",
				City = "Bywater",
				StateProvince = "Shire",
				Country = "Middle Earth",
				PostalCode = "146"
			};
			addressList.Add(address);

			return addressList;
		}

		/// <summary>
		/// Saves the current address.
		/// </summary>
		/// 
		public static bool Save(Address address)
		{
			if (address is null)
			{
				throw new ArgumentNullException(nameof(address));
			}

			return true;
		}
	}
}
