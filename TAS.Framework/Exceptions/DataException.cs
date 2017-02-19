//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

using System;

namespace TAS.Framework.Exceptions
{
	/// <summary>
	/// WebAPIException
	/// </summary>
	/// <seealso cref="System.Exception" />
	public class DataException: Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DataException"/> class.
		/// </summary>
		public DataException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DataException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public DataException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DataException"/> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="exception">The exception.</param>
		public DataException(string message, Exception exception)
			: base(message, exception)
		{
		}			
	}

	/// <summary>
	/// Data exception messages
	/// </summary>
	public static class DataExceptionMessages
	{
		/// <summary>
		/// The load departments error
		/// </summary>
		public const string LOAD_DEPARTMENTS_ERROR =
			"Attention! There was an error in loading departments. Look at the inner exception for details.";

		/// <summary>
		/// The load items error
		/// </summary>
		public const string LOAD_ITEMS_ERROR =
			"Attention! There was an error in loading items. Look at the inner exception for details.";

		/// <summary>
		/// The load taxs error
		/// </summary>
		public const string LOAD_TAXES_ERROR =
			"Attention! There was an error in loading tax. Look at the inner exception for details.";

    /// <summary>
    /// The fill basket error
    /// </summary>
    public const string FILL_BASKET_ERROR =
    "Attention! There was an error in filling basket. Look at the inner exception for details.";
  }
}
