//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Charge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Charge()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int ID { get; set; }
        public int Bar_Charge { get; set; }
        public int Internet_Charge { get; set; }
        public int Phone_Charge { get; set; }
        public int Room_Charge { get; set; }
        public int Additional_Charges { get; set; }
        public string Additional_Charges_Info { get; set; }
        public Nullable<int> Total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}