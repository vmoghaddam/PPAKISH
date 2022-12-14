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
    
    public partial class GetFixTimeRedirect_Result
    {
        public int Id { get; set; }
        public int FDPId { get; set; }
        public Nullable<int> CrewId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string FromAirportIATA { get; set; }
        public string ToAirportIATA { get; set; }
        public Nullable<System.DateTime> STDDayLocal { get; set; }
        public Nullable<System.DateTime> STDDay { get; set; }
        public Nullable<System.DateTime> BlockOff { get; set; }
        public Nullable<System.DateTime> BlockOn { get; set; }
        public Nullable<System.DateTime> STD { get; set; }
        public Nullable<System.DateTime> STA { get; set; }
        public Nullable<System.DateTime> TakeOff { get; set; }
        public Nullable<System.DateTime> Landing { get; set; }
        public Nullable<System.DateTime> DateFDP { get; set; }
        public Nullable<int> PYear { get; set; }
        public string PMonthName { get; set; }
        public Nullable<int> PMonth { get; set; }
        public string PDate { get; set; }
        public string PeriodFixTime { get; set; }
    }
}
