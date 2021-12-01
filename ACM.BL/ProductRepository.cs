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
			Object myObject = new object();
			Console.WriteLine($"Object: {myObject.ToString()}");
			Console.WriteLine($"Product: {product.ToString()}");
			return product;
		}

		/// <summary>
		/// Save the current product.
		/// </summary>
		/// 
		public bool Save(Product product)
		{
			var success = true;

			if (product.HasChanges)
			{
				if (product.IsValid)
				{
					if (product.IsNew)
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
