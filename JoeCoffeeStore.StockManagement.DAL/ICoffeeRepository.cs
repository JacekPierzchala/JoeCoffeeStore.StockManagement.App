using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCoffeeStore.StockManagement.DAL
{
    public interface ICoffeeRepository
    {
        Coffee GetCoffeeById(int coffeeID);
        List<Coffee> GetCoffees();
        void UpdateCoffee(Coffee coffee);
        void DeleteCoffee(Coffee coffee);
    }
}
