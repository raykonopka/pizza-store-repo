//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreData.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class DayTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DayTitle()
        {
            this.DaysOpenEntries = new HashSet<DaysOpenEntry>();
        }
    
        public int Id { get; set; }
        public string DayTitle1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaysOpenEntry> DaysOpenEntries { get; set; }
    }
}