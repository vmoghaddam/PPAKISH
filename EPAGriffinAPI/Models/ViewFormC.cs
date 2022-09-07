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
    
    public partial class ViewFormC
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string YearName { get; set; }
        public string MonthName { get; set; }
        public string YearMonth { get; set; }
        public string Route { get; set; }
        public string AircraftType { get; set; }
        public string FromAirportIATA { get; set; }
        public string ToAirportIATA { get; set; }
        public Nullable<int> Legs { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; }
        public int Adult { get; set; }
        public int RevPax { get; set; }
        public Nullable<int> TotalPax { get; set; }
        public Nullable<double> TotalPaxWeight { get; set; }
        public Nullable<double> RevPaxWeight { get; set; }
        public int TotalSeat { get; set; }
        public Nullable<double> AvailablePayload { get; set; }
        public Nullable<double> FreightTone { get; set; }
        public int BaggageWeight { get; set; }
        public int CargoWeight { get; set; }
        public int Freight { get; set; }
        public int Mail { get; set; }
        public Nullable<bool> IsDom { get; set; }
    }
}
