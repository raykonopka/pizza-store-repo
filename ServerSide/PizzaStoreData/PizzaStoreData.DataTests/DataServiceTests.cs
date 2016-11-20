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
        public void Test_GetPizzas()
        {
            var dataService = new PizzaStoreDataService();

            List<PizzaDAO> actual = dataService.GetPizzas();

            foreach(PizzaDAO p in actual)
            {
                Debug.WriteLine("NEW PIZZA ID BELOW:");
                Debug.WriteLine(p.Id);
            }

            Assert.NotNull(actual);
        }
    }
}
