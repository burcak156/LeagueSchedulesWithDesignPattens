//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;
    
    public partial class takimlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public takimlar()
        {
            this.maclars = new HashSet<maclar>();
            this.maclars1 = new HashSet<maclar>();
        }
    
        public int id { get; set; }
        public string adi { get; set; }
        public string sehir { get; set; }
        public string lig { get; set; }
        public string diger { get; set; }
        public Nullable<int> salonID { get; set; }
    
        public virtual salonlar salonlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<maclar> maclars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<maclar> maclars1 { get; set; }
    }
}
