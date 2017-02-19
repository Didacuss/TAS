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
  /// Service for departments.
  /// </summary>
  public static class DepartmentService
	{
		/// <summary>
		/// Loads the departments.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="DataException"></exception>
		public static List<Department> LoadDepartments()
		{
			try
			{
				List<Department> departments = new List<Department>();

				Department department = new Department
				{
					Code = "001",
					AreaLocation = AreaLocationEnum.Books,
					Description = "books"
				};
				departments.Add(department);

				department = new Department
				{
					Code = "002",
					AreaLocation = AreaLocationEnum.Music,
					Description = "music"
				};
				departments.Add(department);

				department = new Department
				{
					Code = "003",
					AreaLocation = AreaLocationEnum.Confectionery,
					Description = "chocolate"
				};
				departments.Add(department);

				department = new Department
				{
					Code = "004",
					AreaLocation = AreaLocationEnum.PersonCleaning,
					Description = "perfume"
				};
				departments.Add(department);

				department = new Department
				{
					Code = "005",
					AreaLocation = AreaLocationEnum.Parafarmacia,
					Description = "headache"
				};
				departments.Add(department);

				return departments;
			}
			catch (Exception exception)
			{
				throw new DataException(DataExceptionMessages.LOAD_DEPARTMENTS_ERROR, exception);
			}
		} 
	}
}
