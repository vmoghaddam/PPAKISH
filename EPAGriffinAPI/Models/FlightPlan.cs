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
    
    public partial class FlightPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlightPlan()
        {
            this.FlighPlanCalendars = new HashSet<FlighPlanCalendar>();
            this.FlightPlanStatus = new HashSet<FlightPlanStatu>();
            this.FlightPlanDays = new HashSet<FlightPlanDay>();
            this.FlightPlanMonths = new HashSet<FlightPlanMonth>();
            this.FlightPlanRegisters = new HashSet<FlightPlanRegister>();
            this.FlightPlanItems = new HashSet<FlightPlanItem>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public int CustomerId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> DateActive { get; set; }
        public Nullable<int> Interval { get; set; }
        public Nullable<System.DateTime> DateFirst { get; set; }
        public Nullable<System.DateTime> DateLast { get; set; }
        public Nullable<int> BaseId { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlighPlanCalendar> FlighPlanCalendars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPlanStatu> FlightPlanStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPlanDay> FlightPlanDays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPlanMonth> FlightPlanMonths { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPlanRegister> FlightPlanRegisters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPlanItem> FlightPlanItems { get; set; }
    }
}
