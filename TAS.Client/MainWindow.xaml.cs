using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TAS.Data.Entity;
using TAS.Data.Model;
using TAS.Services;

namespace TAS.Client
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private SaleService _saleService = new SaleService();
    private DataService _dataService = new DataService();

    public MainWindow()
    {
      InitializeComponent();

      try
      {
       Items = _dataService.InitData();
      }
      catch (Exception exception)
      {
        MessageBox.Show("Init Totem error! Please, contact the support at the desk information.", "TAS", MessageBoxButton.OK, MessageBoxImage.Error);
        NLog.LogManager.GetLogger("LogErrori").Error(exception);
      }
    }

    #region Public properties 

    /// <summary>
    /// Gets or sets the baskets.
    /// </summary>
    /// <value>
    /// The baskets.
    /// </value>
    public List<BasketModel> Baskets { get; set; }
    /// <summary>
    /// Gets or sets the items.
    /// </summary>
    /// <value>
    /// The items.
    /// </value>
    public List<Item> Items { get; set; }

    #endregion

    #region Events

    private void btnExit_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

    private void btnBuy_Click(object sender, RoutedEventArgs e)
    {
      try
      {
        if (Baskets == null || !Baskets.Any(b => b.IsSelected))
        {
          MessageBox.Show("Warning! You must select at least one basket to buy.", "TAS", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        else
        {
          _saleService.Sell(Baskets);
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show("Buy error! Please, contact the support at the desk information.", "TAS", MessageBoxButton.OK, MessageBoxImage.Error);
        NLog.LogManager.GetLogger("LogErrori").Error(exception);
      }
    }

    private void chkBasket1_Checked(object sender, RoutedEventArgs e)
    {
      try
      {
        Baskets = _dataService.FillBaskets(Baskets, "BK01", "Basket 1", Items);
      }
      catch (Exception exception)
      {
        MessageBox.Show("Fill basket error! Please, contact the support at the desk information.", "TAS", MessageBoxButton.OK, MessageBoxImage.Error);
        NLog.LogManager.GetLogger("LogErrori").Error(exception);
      }
    }

    private void chkBasket2_Checked(object sender, RoutedEventArgs e)
    {
      try
      {
        Baskets = _dataService.FillBaskets(Baskets, "BK02", "Basket 2", Items);
      }
      catch (Exception exception)
      {
        MessageBox.Show("Fill basket error! Please, contact the support at the desk information.", "TAS", MessageBoxButton.OK, MessageBoxImage.Error);
        NLog.LogManager.GetLogger("LogErrori").Error(exception);
      }
    }

    private void chkBasket3_Checked(object sender, RoutedEventArgs e)
    {
      try
      {
        Baskets = _dataService.FillBaskets(Baskets, "BK03", "Basket 3", Items);
      }
      catch (Exception exception)
      {
        MessageBox.Show("Fill basket error! Please, contact the support at the desk information.", "TAS", MessageBoxButton.OK, MessageBoxImage.Error);
        NLog.LogManager.GetLogger("LogErrori").Error(exception);
      }
    }

    private void chkBasket1_Unchecked(object sender, RoutedEventArgs e)
    {
      try
      {
        _saleService.UnselectBasket(Baskets, "BK01");
      }
      catch (Exception exception)
      {
        MessageBox.Show("Unselect basket error! Please, contact the support at the desk information.", "TAS", MessageBoxButton.OK, MessageBoxImage.Error);
        NLog.LogManager.GetLogger("LogErrori").Error(exception);
      }
    }

    private void chkBasket2_Unchecked(object sender, RoutedEventArgs e)
    {
      try
      {
        _saleService.UnselectBasket(Baskets, "BK02");
      }
      catch (Exception exception)
      {
        MessageBox.Show("Unselect basket error! Please, contact the support at the desk information.", "TAS", MessageBoxButton.OK, MessageBoxImage.Error);
        NLog.LogManager.GetLogger("LogErrori").Error(exception);
      }
    }

    private void chkBasket3_Unchecked(object sender, RoutedEventArgs e)
    {
      try
      {
        _saleService.UnselectBasket(Baskets, "BK03");
      }
      catch (Exception exception)
      {
        MessageBox.Show("Unselect basket error! Please, contact the support at the desk information.", "TAS", MessageBoxButton.OK, MessageBoxImage.Error);
        NLog.LogManager.GetLogger("LogErrori").Error(exception);
      }
    }

    #endregion

  }
}
