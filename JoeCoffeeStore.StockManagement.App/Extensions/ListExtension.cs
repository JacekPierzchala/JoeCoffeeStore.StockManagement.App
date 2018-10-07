using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace JoeCoffeeStore.StockManagement.App.Extensions
{
    public static class ListExtension
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> collection)
        {
            var col = new ObservableCollection<T>();
            foreach(var e in collection)
            {
                col.Add(e);
            }

            return col;
        }
    } 
}
