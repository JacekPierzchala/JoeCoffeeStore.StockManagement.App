using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JoeCoffeeStore.StockManagement.DAL
{
    public class CoffeeRepository:ICoffeeRepository
    {
        private static List<Coffee> coffees;

        public CoffeeRepository() { }

        public Coffee GetACoffee()
        {
            if (coffees==null)
            {
                LoadCoffees();
                
            }

            return coffees.FirstOrDefault();
        }

        public List<Coffee> GetCoffees()
        {
            if (coffees==null)
            {
                LoadCoffees();

            }
            return coffees;
        }

        public  void DeleteCoffee(Coffee coffee)
        {
            coffees.Remove(coffee);
        }

        public void UpdateCoffee(Coffee coffee)
        {
            Coffee coffeeToUpdate = coffees.Where(e => e.CoffeeID.Equals(coffee.CoffeeID)).FirstOrDefault();
            coffeeToUpdate = coffee;
        }

        private void LoadCoffees()
        {
            coffees = new List<Coffee>()
            {
                new Coffee()
                {
                    CoffeeID=1,
                    CoffeeName="laTTE",
                    Description="LALALA",
                    ImageID=1,
                    AmonutInStock=10,
                    InStock=true,
                    FirstAddedToStockDate=new DateTime(2017,1,13),
                    //OriginCountry
                    Price=12
                    
                },
                 new Coffee()
                {
                    CoffeeID=2,
                    CoffeeName="Espresso",
                    Description="strong coffee as hell!",
                    ImageID=2,
                    AmonutInStock=13,
                    InStock=true,
                    FirstAddedToStockDate=new DateTime(2016,2,2),
                    //OriginCountry
                    Price=13

                }
            };
        }

    

        public Coffee GetCoffeeById(int coffeeID)
        {
            return coffees.Where(e => e.CoffeeID.Equals(coffeeID)).FirstOrDefault();
        }

    }
}
