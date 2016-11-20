using PizzaStoreAPI.Service.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAPI.Service.Controllers
{
    public class PizzasController : ApiController
    {
        ApplicationLogic processedData = new ApplicationLogic();

        public List<PizzaDAO> GetAllPizzas()
        {
            return processedData.GetPizzas();
        }

    }
}
