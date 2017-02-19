//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.19
//--------------------------------------------------------------------------------------------------------------

using TAS.Data.Entity;

namespace TAS.Data.Model
{
  /// <summary>
  /// Basket for UI.
  /// </summary>
  public class BasketModel
  {
    /// <summary>
    /// Gets or sets the basket.
    /// </summary>
    /// <value>
    /// The basket.
    /// </value>
    public Basket Basket  {get; set;}
    /// <summary>
    /// Gets or sets a value indicating whether this instance is selected.
    /// </summary>
    /// <value>
    /// <c>true</c> if this instance is selected; otherwise, <c>false</c>.
    /// </value>
    public bool IsSelected { get; set; }
  }
}
