using PizzaStoreData.DataAccess;
using PizzaStoreData.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataService
{
    public class DataMapper
    {
        public static PizzaDAO MapToPizzaDAO(Pizza pizzaToMap)
        {
            PizzaDAO  pizza = new PizzaDAO();

            pizza.Id = pizzaToMap.Id;
            pizza.PizzaSize = pizzaToMap.PizzaSizeId;
            pizza.CrustType = pizzaToMap.CrustTypeId;
            pizza.SauceType = pizzaToMap.SauceTypeId;
            pizza.CheeseType = pizzaToMap.CheeseTypeId;
            pizza.Order = pizzaToMap.OrderId;

            return pizza;
        }
    }
}