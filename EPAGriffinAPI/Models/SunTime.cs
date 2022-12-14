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
    
    public partial class SunTime
    {
        public int Id { get; set; }
        public System.DateTime DateCreate { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lng { get; set; }
        public Nullable<int> AirportId { get; set; }
        public Nullable<int> TOffset { get; set; }
        public Nullable<System.DateTime> Sunrise { get; set; }
        public Nullable<System.DateTime> Sunset { get; set; }
        public Nullable<System.DateTime> SolarNoon { get; set; }
        public Nullable<int> DayLength { get; set; }
        public Nullable<System.DateTime> CivilTwilightBegin { get; set; }
        public Nullable<System.DateTime> CivilTwilightEnd { get; set; }
        public Nullable<System.DateTime> NauticalTwilightBegin { get; set; }
        public Nullable<System.DateTime> NauticalTwilightEnd { get; set; }
        public Nullable<System.DateTime> AstronomicalTwilightBegin { get; set; }
        public Nullable<System.DateTime> AstronomicalTwilightEnd { get; set; }
    }
}
