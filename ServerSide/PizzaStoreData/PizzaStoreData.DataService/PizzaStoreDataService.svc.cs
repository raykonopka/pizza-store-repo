using PizzaStoreData.DataAccess;
using PizzaStoreData.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PizzaStoreData.DataService
{
    public class PizzaStoreDataService : IPizzaStoreDataService
    {
        private EfData db = new EfData();

        #region Data Service Implemented - Get Lists

        //Order Management
        public List<OrderDAO> GetOrders()
        {
            var orders = new List<OrderDAO>();

            foreach (var o in db.GetOrders())
            {
                orders.Add(DataMapper.MapToOrderDAO(o));
            }

            return orders;
        }

        public List<PaymentMethodDAO> GetPaymentMethods()
        {
            var paymentMethods = new List<PaymentMethodDAO>();

            foreach (var pm in db.GetPaymentMethods())
            {
                paymentMethods.Add(DataMapper.MapToPaymentMethodDAO(pm));
            }

            return paymentMethods;
        }

        //Store Related



        //Pizza Options
        public List<PizzaDAO> GetPizzas()
        {
            var pizzas = new List<PizzaDAO>();

            foreach (var p in db.GetPizzas())
            {
                pizzas.Add(DataMapper.MapToPizzaDAO(p));
            }

            return pizzas;
        }

        public List<PizzaSizeDAO> GetPizzaSizes()
        {
            var sizes = new List<PizzaSizeDAO>();

            foreach (var ps in db.GetPizzaSizes())
            {
                sizes.Add(DataMapper.MapToPizzaSizeDAO(ps));
            }

            return sizes;
        }

        public List<CrustTypeDAO> GetCrustTypes()
        {
            var crusts = new List<CrustTypeDAO>();

            foreach (var c in db.GetCrustTypes())
            {
                crusts.Add(DataMapper.MapToCrustTypeDAO(c));
            }

            return crusts;
        }

        public List<SauceTypeDAO> GetSauceTypes()
        {
            var sauces = new List<SauceTypeDAO>();

            foreach (var st in db.GetSauceTypes())
            {
                sauces.Add(DataMapper.MapToSauceTypeDAO(st));
            }

            return sauces;
        }

        public List<CheeseTypeDAO> GetCheeseTypes()
        {
            var cheeses = new List<CheeseTypeDAO>();

            foreach (var ct in db.GetCheeseTypes())
            {
                cheeses.Add(DataMapper.MapToCheeseTypeDAO(ct));
            }

            return cheeses;
        }


        //Topping Options
        public List<ToppingDAO> GetToppings()
        {
            var toppings = new List<ToppingDAO>();

            foreach (var top in db.GetToppings())
            {
                toppings.Add(DataMapper.MapToToppingDAO(top));
            }

            return toppings;
        }

        public List<ToppingCategoryDAO> GetToppingCategories()
        {
            var categories = new List<ToppingCategoryDAO>();

            foreach (var tc in db.GetToppingCategories())
            {
                categories.Add(DataMapper.MapToToppingCategoryDAO(tc));
            }

            return categories;
        }

        public List<ToppingPlacementDAO> GetToppingPlacements()
        {
            var placements = new List<ToppingPlacementDAO>();

            foreach (var tp in db.GetToppingPlacements())
            {
                placements.Add(DataMapper.MapToToppingPlacementDAO(tp));
            }

            return placements;
        }

        public List<ToppingListDAO> GetToppingLists()
        {
            var toppingLists = new List<ToppingListDAO>();

            foreach (var tl in db.GetToppingLists())
            {
                toppingLists.Add(DataMapper.MapToToppingListDAO(tl));
            }

            return toppingLists;
        }



        public bool postOrder(OrderDAO newOrder)
        {
            return db.AddNewOrder(newOrder);
        }
        #endregion

    }
}
