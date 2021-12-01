namespace ACM.BL
{
	public class Address
	{
		public Address()
		{

		}
		public Address(int addressID)
		{
			AddressId = addressID;
		}

		public int AddressId { get; set; }
		public int AddressType { get; set; }
		public string StreetLineOne { get; set; }
		public string StreetLineTwo { get; set; }
		public string City { get; set; }
		public string StateProvince { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }

		/// <summary>
		/// Validates the address data.
		/// </summary>
		/// <returns></returns>
		public bool Validate()
		{
			var isValid = true;

			if (PostalCode == null) isValid = false;

			return isValid;
		}

	}
}
