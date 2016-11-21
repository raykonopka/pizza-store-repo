﻿using System.Runtime.Serialization;

namespace PizzaStoreData.DataService
{
    [DataContract]
    public class CrustTypeDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
    }
}