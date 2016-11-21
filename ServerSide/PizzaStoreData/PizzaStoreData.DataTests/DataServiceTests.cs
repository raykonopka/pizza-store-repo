using PizzaStoreData.DataService;
using PizzaStoreData.DataService.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaStoreData.DataTests
{
    public class DataServiceTests
    {
        
        [Fact]
        public void Test_GetSauceTypes()
        {
            var dataService = new PizzaStoreDataService();

            List<SauceTypeDAO> actual = dataService.GetSauceTypes();

            foreach (SauceTypeDAO s in actual)
            {
                Debug.WriteLine("NEW SAUCE NAME BELOW:");
                Debug.WriteLine(s.Name);
            }

            Assert.NotNull(actual);
        }


        [Fact]
        public void Test_PostOrders()
        {
            var dataService = new PizzaStoreDataService();

            OrderDAO orderDAOReceived = new OrderDAO();

            orderDAOReceived.PaymentMethod = 1;
            orderDAOReceived.Timestamp = DateTime.Now;
            orderDAOReceived.Customer = 1;
            orderDAOReceived.Subtotal = decimal.Parse("10.00");
            orderDAOReceived.Taxes = decimal.Parse("2.00"); ;
            orderDAOReceived.Total = decimal.Parse("12.00"); ;


            bool actual = dataService.postOrder(orderDAOReceived);

            Assert.True(actual);
        }
    }
}
