//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.17
//--------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using TAS.Data.Entity;
using TAS.Data.Model;
using TAS.Data.Services;
using TAS.Framework.Exceptions;

namespace TAS.Services
{
  /// <summary>
  /// Service for recovering data.
  /// </summary>
  public class DataService
  {
    /// <summary>
    /// Initializes the data.
    /// </summary>
    /// <returns></returns>
    public List<Item> InitData()
    {
      return ItemService.LoadItems();
    }

    /// <summary>
    /// Fills the baskets.
    /// </summary>
    /// <param name="baskets">The baskets.</param>
    /// <param name="code">The code.</param>
    /// <param name="description">The description.</param>
    /// <param name="items">The items.</param>
    /// <returns></returns>
    public List<BasketModel> FillBaskets(List<BasketModel> baskets, string code, string description, List<Item> items)
    {
      try
      {
        if (baskets == null)
        {
          baskets = new List<BasketModel>();
        }

        switch (code)
        {
          case "BK01":
            // Basket 1
            var basket1 = baskets.FirstOrDefault(b => b.Basket.Code.Equals("BK01"));
            if (basket1 == null)
            {
              var query = from its in items
                          where its.Code.Equals("B001") || its.Code.Equals("MCD001") || its.Code.Equals("CB001")
                          select its;

              List<Item> basketItems = query.ToList();

              Basket basket = new Basket(code, description, basketItems);
              BasketModel basketModel = new BasketModel();
              basketModel.Basket = basket;
              basketModel.IsSelected = true;

              baskets.Add(basketModel);
            }
            else
            {
              basket1.IsSelected = true;
            }

            break;

          case "BK02":
            // Basket 2
            var basket2 = baskets.FirstOrDefault(b => b.Basket.Code.Equals("BK02"));
            if (basket2 == null)
            {
              var query = from its in items
                          where its.Code.Equals("CBXI001") || its.Code.Equals("PI001")
                          select its;

              List<Item> basketItems = query.ToList();

              Basket basket = new Basket(code, description, basketItems);
              BasketModel basketModel = new BasketModel();
              basketModel.Basket = basket;
              basketModel.IsSelected = true;

              baskets.Add(basketModel);
            }
            else
            {
              basket2.IsSelected = true;
            }

            break;

          case "BK03":
            // Basket 3
            var basket3 = baskets.FirstOrDefault(b => b.Basket.Code.Equals("BK03"));
            if (basket3 == null)
            {
              var query = from its in items
                          where its.Code.Equals("PI002") || its.Code.Equals("P001") || its.Code.Equals("HP001") || its.Code.Equals("CBXI002")
                          select its;

              List<Item> basketItems = query.ToList();

              Basket basket = new Basket(code, description, basketItems);
              BasketModel basketModel = new BasketModel();
              basketModel.Basket = basket;
              basketModel.IsSelected = true;

              baskets.Add(basketModel);
            }
            else
            {
              basket3.IsSelected = true;
            }

            break;
        }

        return baskets;
      }
      catch (Exception exception)
      {
        throw new Framework.Exceptions.ApplicationException(ApplicationExceptionMessages.FILL_BASKET_ERROR, exception);
      }
    }
  }
}
