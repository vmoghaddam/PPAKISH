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
    
    public partial class ViewRegisterGround
    {
        public int RegisterId { get; set; }
        public int GroundTypeId { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<System.DateTime> DateFromLocal { get; set; }
        public Nullable<System.DateTime> DateEndLocal { get; set; }
        public string Remark { get; set; }
        public string GroundType { get; set; }
        public Nullable<int> MSN { get; set; }
        public string Register { get; set; }
        public string Model { get; set; }
        public Nullable<int> AircraftTypeId { get; set; }
        public string AircraftType { get; set; }
        public Nullable<int> ManufacturerId { get; set; }
        public string Manufacturer { get; set; }
        public string Customer { get; set; }
        public Nullable<bool> isvirtual { get; set; }
        public string AirlineOperators { get; set; }
        public int CustomerId { get; set; }
        public int AirlineOperatorsID { get; set; }
        public Nullable<decimal> duration { get; set; }
        public int FlightStatusID { get; set; }
        public string FlightStatus { get; set; }
        public Nullable<int> TypeId { get; set; }
        public int Id { get; set; }
        public Nullable<int> taskId { get; set; }
        public int FlightTypeID { get; set; }
    }
}
