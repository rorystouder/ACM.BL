﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
	public class Order : EntityBase
	{
		public Order() : this(0)
		{

		}
		public Order(int orderId)
		{
			OrderId = orderId;
			orderItems = new List<OrderItem>();
		}

		public int CustomerId { get; set; }
		public DateTimeOffset? OrderDate {get; set;}
		public int OrderId { get; private set; }

		private List<OrderItem> orderItems;

		public List<OrderItem> GetOrderItems()
		{
			return orderItems;
		}

		public void SetOrderItems(List<OrderItem> value)
		{
			orderItems = value;
		}

		public int ShippingAddressId { get; set; }

		public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

		/// <summary>
		/// Validates the order data.
		/// </summary>
		/// 
		public override bool Validate()
		{
			var isValid = true;

			if (OrderDate == null) isValid = false;

			return isValid;
		}
	}
}
