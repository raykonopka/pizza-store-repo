//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreData.DataService
{
    using System;
    using System.Collections.Generic;
    
    public partial class DaysOpen
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int DayOpenEntryId { get; set; }
    
        public virtual DaysOpenEntry DaysOpenEntry { get; set; }
        public virtual Store Store { get; set; }
    }
}
