using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JoeCoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeDetailView.xaml
    /// </summary>
    public partial class CoffeeDetailView : Window
    {
        public Coffee SelectedCoffee { get; set; }

        public CoffeeDetailView()
        {
            InitializeComponent();
            this.Loaded += CoffeeDetail_Loaded;
        }


        void CoffeeDetail_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = SelectedCoffee;
        }

      //  private void LoadData()
        //{
        //    CoffeeNamelabel.Content = SelectedCoffee.CoffeeName;
        //    CoffeeIdbox.Text = SelectedCoffee.CoffeeID.ToString();
        //    CoffeeDescrptionbox.Text = SelectedCoffee.Description;
        //    CoffeePrincebox.Text = SelectedCoffee.Price.ToString();
        //    CoffeeStockAmountbox.Text = SelectedCoffee.AmonutInStock.ToString();
        //    CoffeeFirstTimeAddedbox.Text = SelectedCoffee.FirstAddedToStockDate.ToShortDateString();
        //    if (SelectedCoffee is SuperiorCoffee)
        //    {
        //        //CoffeeExtraDescrbox.Text = (SelectedCoffee as SuperiorCoffee).ExtraDesription.ToString();
        //    }
        //    else
        //    {
        //        CoffeeExtraDescrbox.Text = "NA";
        //    }

        //        //
        //    }
        
    }
}
