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
    [ServiceContract]
    public interface IPizzaStoreDataService
    {
        [OperationContract]
        List<PizzaDAO> GetPizzas();
    }

}
