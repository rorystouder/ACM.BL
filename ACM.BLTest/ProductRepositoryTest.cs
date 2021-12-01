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

		[TestMethod()]
		public void SaveTestValid()
		{
			// -- Arrange
			var productRepository = new ProductRepository();
			var updatedProduct = new Product(2)
			{
				CurrentPrice = 1000000000000.00M,
				ProductDescription = "To Rule Them All",
				ProductName = "The One Ring",
				HasChanges = true
			};

			// -- Act
			var actual = productRepository.Save(updatedProduct);

			// -- Assert
			Assert.AreEqual(true, actual);
		}

		[TestMethod()]
		public void SaveTestMissingPrice()
		{
			// -- Arrange
			var productRepository = new ProductRepository();
			var updatedProduct = new Product(2)
			{
				CurrentPrice = null,
				ProductDescription = "To Rule Them All",
				ProductName = "The One Ring",
				HasChanges = true
			};

			// -- Act
			var actual = productRepository.Save(updatedProduct);

			// -- Assert
			Assert.AreEqual(false, actual);
		}

	}
}
