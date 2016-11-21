using PizzaStoreAPI.Service.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.Service
{
    public class ApplicationLogic
    {
        private PizzaStoreDataServiceClient psDataClient = new PizzaStoreDataServiceClient();

        #region Functions For Ordering Pizza

        //Pizza Options
        public List<PizzaSizeDAO> GetPizzaSizes()
        {
            return psDataClient.GetPizzaSizes().ToList();
        }

        public List<SauceTypeDAO> GetSauceTypes()
        {
            return psDataClient.GetSauceTypes().ToList();
        }

        public List<CrustTypeDAO> GetCrustTypes()
        {
            return psDataClient.GetCrustTypes().ToList();
        }

        public List<CheeseTypeDAO> CheeseTypes()
        {
            return psDataClient.GetCheeseTypes().ToList();
        }


        //Topping Options
        public List<ToppingDAO> GetToppings()
        {
            return psDataClient.GetToppings().ToList();
        }

        public List<ToppingCategoryDAO> GetToppingCategories()
        {
            return psDataClient.GetToppingCategories().ToList();
        }

        public List<ToppingPlacementDAO> GetToppingPlacements()
        {
            return psDataClient.GetToppingPlacements().ToList();
        }

        public List<ToppingListDAO> GetToppingList()
        {
            return psDataClient.GetToppingLists().ToList();
        }


        //Orders
        public List<OrderDAO> GetOrders()
        {
            return psDataClient.GetOrders().ToList();
        }

        #endregion


    }
}