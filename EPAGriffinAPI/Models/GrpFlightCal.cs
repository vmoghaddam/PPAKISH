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
    
    public partial class GrpFlightCal
    {
        public int Year { get; set; }
        public string MonthName { get; set; }
        public int Month { get; set; }
        public int PYear { get; set; }
        public string PMonthName { get; set; }
        public int PMonth { get; set; }
        public Nullable<int> FlightCount { get; set; }
        public int PreFlightCount { get; set; }
        public Nullable<decimal> FlightCountDiff { get; set; }
        public Nullable<int> BlockTime { get; set; }
        public int PreBlockTime { get; set; }
        public Nullable<decimal> BlockTimeDiff { get; set; }
        public Nullable<int> FlightTime { get; set; }
        public int PreFlightTime { get; set; }
        public Nullable<decimal> FlightTimeDiff { get; set; }
        public Nullable<int> TotalPax { get; set; }
        public int PreTotalPax { get; set; }
        public Nullable<decimal> TotalPaxDiff { get; set; }
        public Nullable<int> TotalPaxAll { get; set; }
        public int PreTotalPaxAll { get; set; }
        public Nullable<decimal> TotalPaxAllDiff { get; set; }
    }
}