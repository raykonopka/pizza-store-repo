using System.Runtime.Serialization;

namespace PizzaStoreData.DataService
{
    [DataContract]
    public class ToppingCategoryDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}