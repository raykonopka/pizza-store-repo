using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreUI.MVC.Models
{
    public class PizzaModel
    {
        public List<SelectListItem> Options { get; set; }
        public string Sauce { get; set; }

        public PizzaModel()
        {
            Options = ClientHelper.GetSauces();
        }
    }
}