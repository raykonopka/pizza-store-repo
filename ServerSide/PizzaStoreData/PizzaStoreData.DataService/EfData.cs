using PizzaStoreData.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreData.DataAccess
{
    public class EfData
    {
        private PizzaStoreDBEntities db = new PizzaStoreDBEntities();

        #region Data Access - Get Lists
        
        //Order Management
        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }


        //Store Related
        public List<Store> GetStores()
        {
            return db.Stores.ToList();
        }

        public List<DaysOpen> GetDaysOpen()
        {
            return db.DaysOpens.ToList();
        }

        public List<DaysOpenEntry> GetDaysOpenEntries()
        {
            return db.DaysOpenEntries.ToList();
        }

        public List<DayTitle> GetDayTitles()
        {
            return db.DayTitles.ToList();
        }


        //Pizza Options
        public List<Pizza> GetPizzas()
        {
            return db.Pizzas.ToList();
        }

        public List<PizzaSize> GetPizzaSizes()
        {
            return db.PizzaSizes.ToList();
        }
        
        public List<CrustType> GetCrustTypes()
        {
            return db.CrustTypes.ToList();
        }

        public List<SauceType> GetSauceTypes()
        {
            return db.SauceTypes.ToList();
        }

        public List<CheeseType> GetCheeseTypes()
        {
            return db.CheeseTypes.ToList();
        }


        //Topping Options
        public List<Topping> GetToppings()
        {
            return db.Toppings.ToList();
        }

        public List<ToppingCategory> GetToppingCategories()
        {
            return db.ToppingCategories.ToList();
        }

        public List<ToppingPlacement> GetToppingPlacements()
        {
            return db.ToppingPlacements.ToList();
        }

        public List<ToppingList> GetToppingLists()
        {
            return db.ToppingLists.ToList();
        }

        #endregion

    }
}
