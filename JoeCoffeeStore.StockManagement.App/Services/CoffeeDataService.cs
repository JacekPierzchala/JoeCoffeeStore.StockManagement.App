using JoeCoffeeStore.StockManagement.DAL;
using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCoffeeStore.StockManagement.App.Services
{
    public class CoffeeDataService: ICoffeeDataService
    {
        ICoffeeRepository repository = new CoffeeRepository();

        public CoffeeDataService() { }

        public Coffee GefCoffeeDetail(int coffeeID)
        {
            return repository.GetCoffeeById(coffeeID);
        }

        public List<Coffee> GetAllCoffees()
        {
            return repository.GetCoffees();
        }

        public void UpdateCoffee(Coffee coffee)
        {
            repository.UpdateCoffee(coffee);
        }

        public void DeleteCoffee(Coffee coffee)
        {
            repository.DeleteCoffee(coffee);
        }
    }
    
}
