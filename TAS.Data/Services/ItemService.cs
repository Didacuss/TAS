//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using TAS.Data.Entity;
using TAS.Framework.Exceptions;

namespace TAS.Data.Services
{
  /// <summary>
  /// Service for items.
  /// </summary>
  public static class ItemService
	{
    /// <summary>
    /// Loads the items.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="DataException"></exception>
    public static List<Item> LoadItems()
		{
			try
			{
				List<Item> items = new List<Item>();

				List<Department> departments = DepartmentService.LoadDepartments();
        List<Tax> taxes = TaxService.LoadTaxes();

        Item item = new Item
				{
					Id = 1,
					Code = "B001",
          Department = departments.FirstOrDefault(d => d.Code.Equals("001")),
          Description = "book",
					Price = 12.49m
				};
				items.Add(item);

				item = new Item
				{
					Id = 2,
					Code = "MCD001",
          Department = departments.FirstOrDefault(d => d.Code.Equals("002")),
          Description = "music CD",
					Price = 14.99m,
          Tax = taxes.FirstOrDefault(d => d.Code.Equals("10"))
        };
				items.Add(item);

				item = new Item
				{
					Id = 3,
					Code = "CB001",
          Department = departments.FirstOrDefault(d => d.Code.Equals("003")),
          Description = "chocolate bar",
					Price = (decimal) 0.85
				};
				items.Add(item);

				item = new Item
				{
					Id = 4,
					Code = "CBXI001",
          Department = departments.FirstOrDefault(d => d.Code.Equals("003")),
          Description = "box of chocolates",
          ImportedTax = taxes.FirstOrDefault(d => d.Code.Equals("05")),
          Price = 10.00m
        };
				items.Add(item);

				item = new Item
				{
					Id = 5,
					Code = "PI001",
          Department = departments.FirstOrDefault(d => d.Code.Equals("004")),
          Description = "bottle of perfume",
          ImportedTax = taxes.FirstOrDefault(d => d.Code.Equals("05")),
          Price = 47.50m,
          Tax = taxes.FirstOrDefault(d => d.Code.Equals("10"))
        };
				items.Add(item);

				item = new Item
				{
					Id = 6,
					Code = "PI002",
          Department = departments.FirstOrDefault(d => d.Code.Equals("004")),
          Description = "bottle of perfume",
          ImportedTax = taxes.FirstOrDefault(d => d.Code.Equals("05")),
          Price = 27.99m,
          Tax = taxes.FirstOrDefault(d => d.Code.Equals("10"))
        };
				items.Add(item);

				item = new Item
				{
					Id = 7,
					Code = "P001",
          Department = departments.FirstOrDefault(d => d.Code.Equals("004")),
          Description = "bottle of perfume",
					Price = 18.99m,
          Tax = taxes.FirstOrDefault(d => d.Code.Equals("10"))
				};
				items.Add(item);

				item = new Item
				{
					Id = 8,
					Code = "HP001",
          Department = departments.FirstOrDefault(d => d.Code.Equals("005")),
          Description = "headache pills",
					Price = 9.75m
				};
				items.Add(item);

				item = new Item
				{
					Id = 9,
					Code = "CBXI002",
          Department = departments.FirstOrDefault(d => d.Code.Equals("004")),
          Description = "box of chocolates",
          ImportedTax = taxes.FirstOrDefault(d => d.Code.Equals("05")),
          Price = 11.25m
        };
				items.Add(item);

				return items;
			}
			catch (Exception exception)
			{
				throw new DataException(DataExceptionMessages.LOAD_ITEMS_ERROR, exception);
			}
		}
	}
}
