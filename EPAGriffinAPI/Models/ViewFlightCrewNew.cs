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
    
    public partial class ViewFlightCrewNew
    {
        public int FDPId { get; set; }
        public int FDPItemId { get; set; }
        public Nullable<int> CrewId { get; set; }
        public Nullable<int> FlightId { get; set; }
        public Nullable<bool> IsPositioning { get; set; }
        public int PositionId { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public Nullable<int> GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int SexId { get; set; }
        public string Sex { get; set; }
        public int GroupOrder { get; set; }
        public string FDPTitle { get; set; }
        public int IsCockpit { get; set; }
        public string PID { get; set; }
        public Nullable<long> Rank { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
