using PizzaStoreData.DataAccess;
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

        public List<Pizza> GetPizzas()
        {
            return db.GetPizzas();
        }
    }
}
