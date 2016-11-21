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
        #region Order Management
        public static OrderDAO MapToOrderDAO(Order orderToMap)
        {
            OrderDAO order = new OrderDAO();

            order.Id = orderToMap.Id;
            order.Subtotal = orderToMap.Subtotal;
            order.Taxes = orderToMap.Taxes;
            order.Total = orderToMap.Total;
            order.Timestamp = orderToMap.OrderDateTime;
            order.Customer = orderToMap.CustomerId;
            order.PaymentMethod = orderToMap.PaymentMethodId;

            return order;
        }

        public static PaymentMethodDAO MapToPaymentMethodDAO(PaymentMethod paymentMethodToMap)
        {
            PaymentMethodDAO paymentMethod = new PaymentMethodDAO();

            paymentMethod.Id = paymentMethodToMap.Id;
            paymentMethod.Name = paymentMethodToMap.PaymentName;

            return paymentMethod;
        }

        #endregion

        #region Store Related



        #endregion

        #region Pizza Options

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

        public static SauceTypeDAO MapToSauceTypeDAO(SauceType sauceTypeToMap)
        {
            SauceTypeDAO sauceType = new SauceTypeDAO();

            sauceType.Id = sauceTypeToMap.Id;
            sauceType.Name = sauceTypeToMap.SauceTypeName;
            sauceType.Price = sauceTypeToMap.SaucePrice;

            return sauceType;
        }

        public static CrustTypeDAO MapToCrustTypeDAO(CrustType crustTypeToMap)
        {
            CrustTypeDAO crustType = new CrustTypeDAO();

            crustType.Id = crustTypeToMap.Id;
            crustType.Name = crustTypeToMap.CrustTypeName;
            crustType.Price = crustTypeToMap.CrustPrice;

            return crustType;
        }

        public static CheeseTypeDAO MapToCheeseTypeDAO(CheeseType cheeseTypeToMap)
        {
            CheeseTypeDAO cheeseType = new CheeseTypeDAO();

            cheeseType.Id = cheeseTypeToMap.Id;
            cheeseType.Name = cheeseTypeToMap.CheeseTypeName;
            cheeseType.Price = cheeseTypeToMap.CheesePrice;

            return cheeseType;
        }

        public static PizzaSizeDAO MapToPizzaSizeDAO(PizzaSize pizzaSizeToMap)
        {
            PizzaSizeDAO pizzaSize = new PizzaSizeDAO();

            pizzaSize.Id = pizzaSizeToMap.Id;
            pizzaSize.Name = pizzaSizeToMap.SizeName;
            pizzaSize.Price = pizzaSizeToMap.SizePrice;
           
            return pizzaSize;
        }

        #endregion

        #region Topping Options

        public static ToppingDAO MapToToppingDAO(Topping toppingToMap)
        {
            ToppingDAO topping = new ToppingDAO();

            topping.Id = toppingToMap.Id;
            topping.Name = toppingToMap.ToppingName;
            topping.Price = toppingToMap.Price;
            topping.Category = toppingToMap.ToppingCategoryId;

            return topping;
        }

        public static ToppingCategoryDAO MapToToppingCategoryDAO(ToppingCategory toppingCategoryToMap)
        {
            ToppingCategoryDAO toppingCategory = new ToppingCategoryDAO();

            toppingCategory.Id = toppingCategoryToMap.Id;
            toppingCategory.Name = toppingCategoryToMap.CategoryName;

            return toppingCategory;
        }

        public static ToppingPlacementDAO MapToToppingPlacementDAO(ToppingPlacement toppingPlacementToMap)
        {
            ToppingPlacementDAO toppingPlacement = new ToppingPlacementDAO();

            toppingPlacement.Id = toppingPlacementToMap.Id;
            toppingPlacement.Type = toppingPlacementToMap.Placement;

            return toppingPlacement;
        }

        public static ToppingListDAO MapToToppingListDAO(ToppingList toppingListToMap)
        {
            ToppingListDAO toppingList = new ToppingListDAO();

            toppingList.Id = toppingListToMap.Id;
            toppingList.Topping = toppingListToMap.ToppingId;
            toppingList.Placement = toppingListToMap.ToppingPlacementId;
            toppingList.Pizza = toppingListToMap.PizzaId;

            return toppingList;
        }

        #endregion

    }
}