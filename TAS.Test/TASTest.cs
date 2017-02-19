using Microsoft.VisualStudio.TestTools.UnitTesting;
using TAS.Data.Services;
using TAS.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace TAS.Test
{
  [TestClass]
  public class TASTest
  {
    [TestMethod]
    public void TestLoadDepartments()
    {
      List<Department> departments = DepartmentService.LoadDepartments();

      Assert.IsTrue(departments.Count == 5);
    }

    [TestMethod]
    public void TestLoadTaxes()
    {
      List<Tax> taxes = TaxService.LoadTaxes();

      Assert.IsTrue(taxes.Count == 2);
    }

    [TestMethod]
    public void TestLoadItems()
    {
      List<Item> items = ItemService.LoadItems();

      Assert.IsTrue(items.Count == 9);
    }

    [TestMethod]
    public void TestTaxAmout()
    {
      List<Department> departments = DepartmentService.LoadDepartments();
      List<Tax> taxes = TaxService.LoadTaxes();

      Item item = new Item
      {
        Id = 2,
        Code = "MCD001",
        Department = departments.FirstOrDefault(d => d.Code.Equals("002")),
        Description = "music CD",
        Price = 14.99m,
        Tax = taxes.FirstOrDefault(d => d.Code.Equals("10"))
      };

      decimal taxAmount = item.TaxAmount;
      Assert.IsTrue(taxAmount == 1.50m);
    }
  }
}
