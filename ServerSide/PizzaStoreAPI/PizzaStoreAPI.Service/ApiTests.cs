using PizzaStoreAPI.Service.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaStoreAPI.Tests
{
    public class ApiTests
    {
        [Fact]
        public void Test_GetPizzas()
        {
            PizzaStoreDataServiceClient psDataClient = new PizzaStoreDataServiceClient();

            var actual = psDataClient.GetPizzas().ToList();

            foreach (PizzaDAO p in actual)
            {
                Debug.WriteLine("NEW PIZZA ID BELOW:");
                Debug.WriteLine(p.Id);
            }

            Assert.NotNull(actual);
        }
    }
}
