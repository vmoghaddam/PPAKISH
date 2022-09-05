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
    
    public partial class ViewFDPItem
    {
        public int Id { get; set; }
        public int FDPId { get; set; }
        public Nullable<int> FlightId { get; set; }
        public Nullable<bool> IsSector { get; set; }
        public Nullable<bool> IsOff { get; set; }
        public Nullable<bool> IsPositioning { get; set; }
        public Nullable<bool> IsCanceled { get; set; }
        public string FlightNumber { get; set; }
        public Nullable<System.DateTime> DepartureLocal { get; set; }
        public Nullable<System.DateTime> DepartureDay { get; set; }
        public Nullable<System.DateTime> ArrivalLocal { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<System.DateTime> STD { get; set; }
        public Nullable<System.DateTime> STA { get; set; }
        public Nullable<int> FlightStatusID { get; set; }
        public Nullable<int> FromAirport { get; set; }
        public Nullable<int> FromAirportCityId { get; set; }
        public Nullable<int> ToAirport { get; set; }
        public string FromAirportIATA { get; set; }
        public string ToAirportIATA { get; set; }
        public Nullable<int> ACTypeId { get; set; }
        public string Register { get; set; }
        public string AircraftType { get; set; }
        public Nullable<int> Break { get; set; }
        public Nullable<int> WOCL { get; set; }
        public Nullable<decimal> SplitDutyExtension { get; set; }
        public Nullable<int> SplitDutyPairId { get; set; }
        public Nullable<bool> SplitDuty { get; set; }
        public Nullable<long> Rank { get; set; }
        public Nullable<long> RankDesc { get; set; }
        public Nullable<int> PositionId { get; set; }
        public Nullable<int> RosterPositionId { get; set; }
        public string Position { get; set; }
    }
}
