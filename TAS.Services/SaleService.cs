//--------------------------------------------------------------------------------------------------------------
// Created by		: Diego Parolin
// Copyright		: 2017.02.18
//--------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using TAS.Data.Entity;
using TAS.Data.Model;
using TAS.Framework.Exceptions;

namespace TAS.Services
{
  /// <summary>
  /// Service for selling.
  /// </summary>
  public class SaleService
  {
    /// <summary>
    /// Sells the specified baskets.
    /// </summary>
    /// <param name="baskets">The baskets.</param>
    /// <exception cref="TAS.Framework.Exceptions.ApplicationException"></exception>
    public void Sell(List<BasketModel> baskets)
    {
      try
      {
        List<ReceiptRow> receiptRows = new List<ReceiptRow>();
        ReceiptRow receiptRow = null;

        var basketSelected = baskets.Where(b => b.IsSelected).OrderBy(b => b.Basket.Code);
        foreach (var basket in basketSelected)
        {
          decimal salesTaxes = 0;
          decimal total = 0;

          // Title
          receiptRow = new ReceiptRow();
          receiptRow.Description = $"Basket {basket.Basket.Description}:\r\n";

          receiptRows.Add(receiptRow);
          foreach (var item in basket.Basket.Items)
          {
            receiptRow = new ReceiptRow();

            receiptRow.Description = $"{1} {item.Description}: {item.TotalAmount.ToString("0.00")}\r\n";
            receiptRows.Add(receiptRow);

            salesTaxes += item.TaxAmount + item.ImportedTaxAmount;
            total += item.TotalAmount;
          }
          // Tax
          receiptRow = new ReceiptRow();
          receiptRow.Description = $"Sales Taxes: {salesTaxes.ToString("0.00")}\r\n";
          receiptRows.Add(receiptRow);

          // Total
          receiptRow = new ReceiptRow();
          receiptRow.Description = $"Total: {total.ToString("0.00")}\r\n";
          receiptRows.Add(receiptRow);

          // Line feed
          receiptRow = new ReceiptRow();
          receiptRow.Description = "\r\n";
          receiptRows.Add(receiptRow);
        }

        PrintReceipt(receiptRows);
      }
      catch (Exception exception)
      {
        throw new Framework.Exceptions.ApplicationException(ApplicationExceptionMessages.SELL_BASKET_ERROR, exception);
      }
    }

    /// <summary>
    /// Unselects the basket.
    /// </summary>
    /// <param name="baskets">The baskets.</param>
    /// <param name="code">The code.</param>
    public void UnselectBasket(List<BasketModel> baskets, string code)
    {
      var basket = baskets.FirstOrDefault(b => b.Basket.Code.Equals(code));
      if (basket != null)
      {
        basket.IsSelected = false;
      }
    }

    #region Private procedures

    /// <summary>
    /// Prints the receipt.
    /// </summary>
    /// <param name="receiptRows">The receipt rows.</param>
    private void PrintReceipt(List<ReceiptRow> receiptRows)
    {
      try
      {
        StringBuilder row = new StringBuilder();
        foreach (var receiptRow in receiptRows)
        {
          row.Append(receiptRow.Description);
        }

        string receiptFile = System.Configuration.ConfigurationManager.AppSettings["ReceiptFile"];
        File.WriteAllText(receiptFile, row.ToString());

        Process.Start("notepad.exe", receiptFile);
      }
      catch (Exception exception)
      {
        throw new Framework.Exceptions.ApplicationException(ApplicationExceptionMessages.PRINT_RECEIPT_ERROR, exception);
      }
    }

    #endregion
  }
}
