namespace ACM.BL
{
	class Product
	{
		public Product()
		{

		}
		public Product(int productId)
		{
			ProductId = productId;
		}

		public decimal? CurrentPrice { get; set; }
		public string ProductDescription { get; set; }
		public int ProductId { get; set; }
		public string ProductName { get; set; }

		/// <summary>
		/// Retrieve one product.
		/// </summary>
		///
		public Product Retrieve(int productId)
		{
			// Code that retrieves the defined product

			return new Product();
		}
		
		/// <summary>
		/// Saves the product.
		/// </summary>
		///
		public bool Save()
		{
			// Code that saves the defined product

			return true;
		}

		/// <summary>
		/// Validates the product data.
		/// </summary>
		///
		public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}
	}
}
