//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace TAS.Data.Entity
{
	/// <summary>
	/// A basket of items.
	/// </summary>
	public class Basket: BaseEntity
	{
    /// <summary>
    /// Initializes a new instance of the <see cref="Basket"/> class.
    /// </summary>
    public Basket()
    {
      Items = new List<Item>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Basket"/> class.
    /// </summary>
    /// <param name="code">The code.</param>
    /// <param name="description">The description.</param>
    /// <param name="items">The items.</param>
    public Basket(string code, string description, List<Item> items)
		{
      Code = code;
      Description = description;
			Items = items;
		}

		/// <summary>
		/// Gets or sets the items.
		/// </summary>
		/// <value>
		/// The items.
		/// </value>
		public List<Item> Items { get; set; }
	}
}
