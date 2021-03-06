﻿using JoeCoffeeStore.StockManagement.App.Extensions;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView : Window
    {
        private Coffee SelectedCoffee;

        private ObservableCollection<Coffee> coffees;
        public CoffeeOverviewView()
        {
            InitializeComponent();
            LoadData();
            //this.DataContext = coffees;
            CoffeeListView.ItemsSource = coffees;

        }

        private void LoadData()
        {
            CoffeeDataService coffeeDataService = new CoffeeDataService();
            coffees = coffeeDataService.GetAllCoffees().ToObservableCollection();
        }


    }

}
