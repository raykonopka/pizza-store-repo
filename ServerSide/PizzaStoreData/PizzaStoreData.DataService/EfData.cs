using PizzaStoreData.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreData.DataAccess
{
    public class EfData
    {
        private PizzaStoreDBEntities db = new PizzaStoreDBEntities();

        public List<Pizza> GetPizzas()
        {
            return db.Pizzas.ToList();
        }

    }
}
