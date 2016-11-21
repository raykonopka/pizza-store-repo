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

    }
}
