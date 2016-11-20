using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.DataService.Models
{
    [DataContract]
    public class PizzaDAO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PizzaSize { get; set; }

        [DataMember]
        public int CrustType { get; set; }

        [DataMember]
        public int SauceType { get; set; }

        [DataMember]
        public int CheeseType { get; set; }

        [DataMember]
        public int Order { get; set; }
    }
}