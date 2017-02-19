//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.19
//--------------------------------------------------------------------------------------------------------------

using System;

namespace TAS.Framework.Exceptions
{
	/// <summary>
	/// WebAPIException
	/// </summary>
	/// <seealso cref="System.Exception" />
	public class ApplicationException: Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApplicationException"/> class.
		/// </summary>
		public ApplicationException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ApplicationException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public ApplicationException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ApplicationException"/> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="exception">The exception.</param>
		public ApplicationException(string message, Exception exception)
			: base(message, exception)
		{
		}			
	}

	/// <summary>
	/// Application exception messages
	/// </summary>
	public static class ApplicationExceptionMessages
	{
    /// <summary>
    /// The sell basket error
    /// </summary>
    public const string SELL_BASKET_ERROR =
			"Attention! There was an error in selling basket. Look at the inner exception for details.";

    /// <summary>
    /// The fill basket error
    /// </summary>
    public const string FILL_BASKET_ERROR =
      "Attention! There was an error in filling the basket. Look at the inner exception for details.";

    /// <summary>
    /// The print receipt error
    /// </summary>
    public const string PRINT_RECEIPT_ERROR =
      "Attention! There was an error in receipt printing. Look at the inner exception for details.";
  }
}
