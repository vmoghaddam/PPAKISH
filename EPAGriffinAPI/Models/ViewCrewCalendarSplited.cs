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
    
    public partial class ViewCrewCalendarSplited
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> DateLocal { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateStartLocal { get; set; }
        public Nullable<System.DateTime> DateEndLocal { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<System.DateTime> DateContactLocal { get; set; }
        public Nullable<System.DateTime> DateContact { get; set; }
        public Nullable<int> BoxId { get; set; }
        public Nullable<System.DateTime> DateCeaseLocal { get; set; }
        public Nullable<System.DateTime> DateCease { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> ActualDuration { get; set; }
        public int IsCeased { get; set; }
        public Nullable<decimal> Duty { get; set; }
        public int NightEncroach { get; set; }
        public bool IsDismissed { get; set; }
    }
}
