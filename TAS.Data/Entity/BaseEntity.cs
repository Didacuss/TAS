//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

namespace TAS.Data.Entity
{
	public abstract class BaseEntity
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public int Id { get; set; }
		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		/// <value>
		/// The code.
		/// </value>
		public string Code { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description { get; set; }
	}
}
