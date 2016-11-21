using PizzaStoreUI.MVC.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Xml.Serialization;

namespace PizzaStoreUI.MVC
{
    public class ApiAccess
    {
        public static List<SauceTypeDAO> getSaucesFromApi()
        {
            HttpClient httpClient = new HttpClient();

            var httpResponse = httpClient.GetAsync("http://ec2-54-147-132-20.compute-1.amazonaws.com/pizza-store-api/api/sauces/").Result;

            if (httpResponse.IsSuccessStatusCode)
            {
                var stream = httpResponse.Content.ReadAsStreamAsync().Result;
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<SauceTypeDAO>));
                List<SauceTypeDAO> sauces = serializer.ReadObject(stream) as List<SauceTypeDAO>;

                return sauces;
            }
            else
            {
                return null;
            }
        }
        
    }
}