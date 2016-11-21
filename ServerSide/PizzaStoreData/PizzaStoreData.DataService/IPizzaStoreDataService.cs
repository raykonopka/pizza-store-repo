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
    [ServiceContract]
    public interface IPizzaStoreDataService
    {

        #region Data Service - Get Lists

        //Order Management
        [OperationContract]
        List<OrderDAO> GetOrders();

        [OperationContract]
        List<PaymentMethodDAO> GetPaymentMethods();


        //Order Related
        [OperationContract]
        bool postOrder(OrderDAO newOrder);



        //Pizza Options
        [OperationContract]
        List<PizzaDAO> GetPizzas();
        
        [OperationContract]
        List<PizzaSizeDAO> GetPizzaSizes();

        [OperationContract]
        List<CrustTypeDAO> GetCrustTypes();

        [OperationContract]
        List<SauceTypeDAO> GetSauceTypes();

        [OperationContract]
        List<CheeseTypeDAO> GetCheeseTypes();


        //Topping Options
        [OperationContract]
        List<ToppingDAO> GetToppings();

        [OperationContract]
        List<ToppingCategoryDAO> GetToppingCategories();

        [OperationContract]
        List<ToppingPlacementDAO> GetToppingPlacements();

        [OperationContract]
        List<ToppingListDAO> GetToppingLists();

        #endregion
    }

}
