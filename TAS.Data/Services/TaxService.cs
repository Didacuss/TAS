//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using TAS.Data.Entity;
using TAS.Framework.Exceptions;

namespace TAS.Data.Services
{
  /// <summary>
  /// Service for taxes.
  /// </summary>
  public static class TaxService
	{
    /// <summary>
    /// Loads the taxes.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="DataException"></exception>
    public static List<Tax> LoadTaxes()
		{
			try
			{
				List<Tax> taxs = new List<Tax>();

				Tax tax = new Tax
				{
					Code = "10",
					Description = "Basic tax",
					Amount = (decimal) 0.1
				};
				taxs.Add(tax);

				tax = new Tax
				{
					Code = "05",
					Description = "Imported tax",
					Amount = (decimal)0.05
				};
				taxs.Add(tax);

				return taxs;
			}
			catch (Exception exception)
			{
				throw new DataException(DataExceptionMessages.LOAD_TAXES_ERROR, exception);
			}
		}

	}
}
