//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirpocketAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FTLFlightTime
    {
        public int FlightId { get; set; }
        public Nullable<System.DateTime> STDDay { get; set; }
        public int FDPItemId { get; set; }
        public int FDPId { get; set; }
        public Nullable<int> ScheduledFlightTime { get; set; }
    }
}