//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

namespace TAS.Data.Entity
{
	public class Department: BaseEntity
	{
		/// <summary>
		/// Gets or sets the area location. (Food, Fresh, 
		/// </summary>
		/// <value>
		/// The area location.
		/// </value>
		public AreaLocationEnum AreaLocation { get; set; }
	}

	/// <summary>
	/// Departments area location.
	/// </summary>
	public enum AreaLocationEnum
	{
		/// <summary>
		/// The fresh
		/// </summary>
		Fresh,
		/// <summary>
		/// The dry
		/// </summary>
		Dry,
		/// <summary>
		/// The person cleaning
		/// </summary>
		PersonCleaning,
		/// <summary>
		/// The books
		/// </summary>
		Books,
		/// <summary>
		/// The music
		/// </summary>
		Music,
		/// <summary>
		/// The confectionery
		/// </summary>
		Confectionery,
		/// <summary>
		/// The parafarmacia
		/// </summary>
		Parafarmacia
	}
}
