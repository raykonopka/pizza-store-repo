using System.Runtime.Serialization;

namespace PizzaStoreData.DataService
{
    [DataContract]
    public class ToppingListDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Pizza { get; set; }
        [DataMember]
        public int Topping { get; set; }
        [DataMember]
        public int Placement { get; set; }

    }
}