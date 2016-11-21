using PizzaStoreUI.MVC.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace PizzaStoreUI.MVC
{
    public class ClientHelper
    {
        public static List<SelectListItem> GetSauces()
        {
            var sauceSelectList = new List<SelectListItem>();

            List<SauceTypeDAO> sauces = ApiAccess.getSaucesFromApi();

            int counter = 1;
            foreach(SauceTypeDAO s in sauces)
            {
                SelectListItem selectItem =  new SelectListItem () { Text = s.Name, Value = counter.ToString() };
                counter++;

                sauceSelectList.Add(selectItem);
            }

            return sauceSelectList;
        }

    }
}