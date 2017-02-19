//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

namespace TAS.Data.Entity
{
	/// <summary>
	/// Tax type.
	/// </summary>
	public class Tax: BaseEntity
	{
		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		/// <value>
		/// The amount.
		/// </value>
		public decimal Amount { get; set; }

	}
}
