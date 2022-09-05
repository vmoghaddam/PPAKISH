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
    
    public partial class DlyGrpFlightCat
    {
        public Nullable<int> PYear { get; set; }
        public string PMonthName { get; set; }
        public Nullable<int> PMonth { get; set; }
        public string PDate { get; set; }
        public int FlightId { get; set; }
        public string ICategory { get; set; }
        public Nullable<int> Delay { get; set; }
        public string FlightNumber { get; set; }
        public Nullable<System.DateTime> ChocksIn { get; set; }
        public Nullable<System.DateTime> Landing { get; set; }
        public Nullable<System.DateTime> Takeoff { get; set; }
        public Nullable<System.DateTime> ChocksOut { get; set; }
        public Nullable<System.DateTime> DepartureLocal { get; set; }
        public Nullable<System.DateTime> ArrivalLocal { get; set; }
        public Nullable<System.DateTime> STDLocal { get; set; }
        public Nullable<System.DateTime> STALocal { get; set; }
        public Nullable<int> RegisterID { get; set; }
        public string Register { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string AircraftType { get; set; }
        public string FromAirportIATA { get; set; }
        public string ToAirportIATA { get; set; }
        public Nullable<int> FromAirport { get; set; }
        public Nullable<int> ToAirport { get; set; }
        public Nullable<int> BlockTime { get; set; }
        public Nullable<int> FlightTime { get; set; }
        public Nullable<int> TotalPax { get; set; }
        public Nullable<int> TotalPaxAll { get; set; }
        public int DelayUnder30 { get; set; }
        public int DelayOver30 { get; set; }
        public int Delay3060 { get; set; }
        public int Delay60120 { get; set; }
        public int Delay120180 { get; set; }
        public int DelayOver180 { get; set; }
        public int DelayOver240 { get; set; }
        public Nullable<int> PaxDelayOver240 { get; set; }
        public Nullable<int> PaxDelayOver30 { get; set; }
        public Nullable<int> PaxDelay3060 { get; set; }
        public Nullable<int> PaxDelay60120 { get; set; }
        public Nullable<int> PaxDelay120180 { get; set; }
        public Nullable<int> PaxDelayOver180 { get; set; }
    }
}
