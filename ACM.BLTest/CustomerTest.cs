using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
	[TestClass]
	public class CustomerTest
	{
		[TestMethod]
		public void FullNameTestVaild()
		{
			// - Arrange
			Customer customer = new()
			{
				FirstName = "Bill",
				LastName = "Rutherford"
			};
			string expected = "Rutherford, Bill";


			// - Act
			string actual = customer.FullName;

			// - Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullNameFirstNameEmpty()
		{
			// - Arrange
			Customer customer = new()
			{
				LastName = "Rutherford"
			};
			string expected = "Rutherford";


			// - Act
			string actual = customer.FullName;

			// - Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullNameLastNameEmpty()
		{
			// - Arrange
			Customer customer = new()
			{
				FirstName = "Bill"
			};
			string expected = "Bill";


			// - Act
			string actual = customer.FullName;

			// - Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StaticTest()
		{
			// - Arrange
			var c1 = new Customer();
			c1.FirstName = "Bilbo";
			Customer.InstanceCount += 1;

			var c2 = new Customer();
			c2.FirstName = "Frodo";
			Customer.InstanceCount += 1;

			var c3 = new Customer();
			c3.FirstName = "Rosie";
			Customer.InstanceCount += 1;

			// - Act

			// - Assert
			Assert.AreEqual(3, Customer.InstanceCount);
		}

		[TestMethod]
		public void ValidateValid()
		{
			// - Arrange
			var customer = new Customer
			{
				LastName = "Baggins",
				EmailAddress = "fbaggins@hobbiton.me"
			};

			var expected = true;

			// - Act
			var actual = customer.Validate();

			// - Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ValidateMissingLastName()
		{
			// - Arrange
			var customer = new Customer
			{
				EmailAddress = "fbaggins@hobbiton.me"
			};

			var expected = false;

			// - Act
			var actual = customer.Validate();

			// - Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
