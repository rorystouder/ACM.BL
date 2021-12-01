using System;

namespace ACM.BL
{
	public class ProductRepository
	{
		/// <summary>
		/// Retrieve one product.
		/// </summary>
		///
		public static Product Retrieve(int productId)
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
		public static bool Save(Product product)
		{
			if (product is null)
			{
				throw new ArgumentNullException(nameof(product));
			}

			return true;
		}
	}
}
