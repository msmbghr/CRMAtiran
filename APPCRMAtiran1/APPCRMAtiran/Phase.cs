//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APPCRMAtiran
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phase()
        {
            this.task = new HashSet<task>();
            this.userRole = new HashSet<userRole>();
        }
    
        public int PhaseID { get; set; }
        public string PhaseName { get; set; }
        public Nullable<int> parentPhaseID { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    
        public virtual project project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<task> task { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userRole> userRole { get; set; }
    }
}
