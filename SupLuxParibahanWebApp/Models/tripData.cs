//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupLuxParibahanWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tripData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tripData()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public string coachNo { get; set; }
        public string startingFrom { get; set; }
        public string destination { get; set; }
        public string departureTime { get; set; }
        public string coachType { get; set; }
        public int farePerSeat { get; set; }
        public string TripStatus { get; set; }
        public Nullable<System.DateTime> MHDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
