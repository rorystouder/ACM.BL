namespace ACM.BL
{
	public class ProductRepository
	{
		/// <summary>
		/// Retrieve one product.
		/// </summary>
		///
		public Product Retrieve(int productId)
		{
			// Create the instance of the Product class
			// Pass in the requested Id
			Product product = new(productId);

			// Code that retrieves the defined product

			// Temporary hard-coded values to return
			// a populated product
			if(productId == 2)
			{
				product.ProductName = "The One Ring";
				product.ProductDescription = "To Rule Them All";
				product.CurrentPrice = 1000000000000.00M;
			}
			return product;
		}

		/// <summary>
		/// Save the current product.
		/// </summary>
		/// 
		public bool Save(Product product)
		{
			return true;
		}
	}
}
