using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCoffeeStore.StockManagement.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        private int coffeeID;
        public int CoffeeID
        {
            get { return coffeeID; }
            set
            {
                coffeeID = value;
                RaisePropertyChanged("CoffeeID");
            }
        }


        public string CoffeeName { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public Country OriginCountry { get; set; }

        public bool InStock { get; set; }

        public int AmonutInStock { get; set; }

        public DateTime FirstAddedToStockDate { get; set; }

        public int ImageID { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }

        }

    }
}
