using System.Runtime.Serialization;

namespace PizzaStoreData.DataService
{
    [DataContract]
    public class ToppingPlacementDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
    }
}