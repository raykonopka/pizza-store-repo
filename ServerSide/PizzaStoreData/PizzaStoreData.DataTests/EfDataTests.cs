using PizzaStoreData.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaStoreData.DataTests
{
    public class EfDataTests
    {
        [Fact]
        public void Test_GetPizzas()
        {
            var data = new EfData();

            var actual = data.GetPizzas();

            Assert.NotNull(actual);
        }
    }
}
