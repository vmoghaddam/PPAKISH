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
    
    public partial class FlightRoute
    {
        public int Id { get; set; }
        public int AirlineId { get; set; }
        public int SourceAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public Nullable<int> Stops { get; set; }
        public string Equipment { get; set; }
        public Nullable<int> FlightH { get; set; }
        public Nullable<int> FlightM { get; set; }
        public Nullable<double> Distance { get; set; }
    }
}