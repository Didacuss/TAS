//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

using System;

namespace TAS.Data.Entity
{
	/// <summary>
	/// Item
	/// </summary>
	public class Item: BaseEntity
	{
		/// <summary>
		/// Gets or sets the department.
		/// </summary>
		/// <value>
		/// The department.
		/// </value>
		public Department Department { get; set; }
		/// <summary>
		/// Gets or sets the tax.
		/// </summary>
		/// <value>
		/// The tax.
		/// </value>
		public Tax Tax { get; set; }
		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>
		/// The price.
		/// </value>
		public decimal Price { get; set; }
		/// <summary>
		/// Gets or sets the imported tax.
		/// </summary>
		/// <value>
		/// The imported tax.
		/// </value>
		public Tax ImportedTax { get; set; }
    public decimal TaxAmount
    {
      get
      {
        if( Tax != null)
        {
          decimal value = (Math.Ceiling((Price * Tax.Amount) * 20) / 20);
          return value;
        }
        return 0;
      }
    }
    public decimal ImportedTaxAmount
    {
      get
      {
        if (ImportedTax != null)
        {
          decimal value = (Math.Ceiling((Price * ImportedTax.Amount) * 20) / 20);
          return value;
        }
        return 0;
      }
    }

    /// <summary>
    /// Gets or sets the total amount.
    /// </summary>
    /// <value>
    /// The total amount.
    /// </value>
    public decimal TotalAmount
    {
      get
      {
        return Price + TaxAmount + ImportedTaxAmount;
      }
    }

    // TODO il prezzo di vendita importato è maggiorato del 5% rispetto al prezzo base, quindi prezzo base + 10% e poi prezzo base + 5%

  }
}
