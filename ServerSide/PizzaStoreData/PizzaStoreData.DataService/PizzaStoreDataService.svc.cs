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
    public class PizzaStoreDataService : IPizzaStoreDataService
    {
        private EfData db = new EfData();

        public List<PizzaDAO> GetPizzas()
        {
            var pizzas = new List<PizzaDAO>();

            foreach (var p in db.GetPizzas())
            {
                pizzas.Add(DataMapper.MapToPizzaDAO(p));
            }

            return pizzas;
        }

    }
}
