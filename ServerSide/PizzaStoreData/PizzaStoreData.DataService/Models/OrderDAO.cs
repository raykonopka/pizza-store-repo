using System;
using System.Runtime.Serialization;

namespace PizzaStoreData.DataService
{
    [DataContract]
    public class OrderDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Nullable<decimal> Subtotal { get; set; }
        [DataMember]
        public Nullable<decimal> Taxes { get; set; }
        [DataMember]
        public Nullable<decimal> Total { get; set; }
        [DataMember]
        public Nullable<DateTime> Timestamp { get; set; }
        [DataMember]
        public int Customer { get; set; }
        [DataMember]
        public int PaymentMethod { get; set; }
    }
}