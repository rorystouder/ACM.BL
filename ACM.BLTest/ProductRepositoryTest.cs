using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
	[TestClass]
	public class ProductRepositoryTest
	{
		[TestMethod]
		public void RetrieveValid()
		{
			// - Arrange
			var productRepository = new ProductRepository();
			var expected = new Product(2)
			{
				CurrentPrice = 1000000000000.00M,
				ProductDescription = "To Rule Them All",
				ProductName = "The One Ring"
			};

			// - Act
			var actual = ProductRepository.Retrieve(2);

			// - Assert
			Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
			Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
			Assert.AreEqual(expected.ProductName, actual.ProductName);
		}
	}
}
