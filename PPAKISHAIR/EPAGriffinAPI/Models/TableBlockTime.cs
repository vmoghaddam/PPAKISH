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
    
    public partial class TableBlockTime
    {
        public int Id { get; set; }
        public Nullable<int> CrewId { get; set; }
        public Nullable<double> BlockTime { get; set; }
        public Nullable<System.DateTime> CDate { get; set; }
        public Nullable<int> FDPId { get; set; }
    
        public virtual FDP FDP { get; set; }
    }
}
