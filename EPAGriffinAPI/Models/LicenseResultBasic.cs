//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPAGriffinAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LicenseResultBasic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LicenseResultBasic()
        {
            this.CourseTypes = new HashSet<CourseType>();
        }
    
        public int Id { get; set; }
        public bool Airframe { get; set; }
        public bool PowerPlant { get; set; }
        public bool Electronics { get; set; }
        public bool Electric { get; set; }
        public string Result { get; set; }
        public Nullable<bool> IsNew { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseType> CourseTypes { get; set; }
    }
}
