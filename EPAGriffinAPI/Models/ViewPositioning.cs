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
    
    public partial class ViewPositioning
    {
        public int Id { get; set; }
        public int FDPId { get; set; }
        public Nullable<int> CrewId { get; set; }
        public Nullable<int> FlightId { get; set; }
        public string FlightNumber { get; set; }
        public Nullable<System.DateTime> STDDay { get; set; }
        public string FromAirportIATA { get; set; }
        public string ToAirportIATA { get; set; }
        public Nullable<System.DateTime> DepartureLocal { get; set; }
        public Nullable<System.DateTime> ArrivalLocal { get; set; }
    }
}
