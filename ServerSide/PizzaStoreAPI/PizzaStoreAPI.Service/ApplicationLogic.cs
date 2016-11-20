using PizzaStoreAPI.Service.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAPI.Service
{
    public class ApplicationLogic
    {
        private PizzaStoreDataServiceClient psDataClient = new PizzaStoreDataServiceClient();

        public List<PizzaDAO> GetPizzas()
        {
            return psDataClient.GetPizzas().ToList();
        }
    }
}