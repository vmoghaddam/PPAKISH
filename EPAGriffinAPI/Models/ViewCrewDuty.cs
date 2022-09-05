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
    
    public partial class ViewCrewDuty
    {
        public int Id { get; set; }
        public int CrewId { get; set; }
        public string Name { get; set; }
        public string ScheduleName { get; set; }
        public string Mobile { get; set; }
        public string JobGroup { get; set; }
        public Nullable<int> GroupId { get; set; }
        public string JobGroupCode { get; set; }
        public int IsCockpit { get; set; }
        public int IsCabin { get; set; }
        public Nullable<System.DateTime> DateLocal { get; set; }
        public string FltNo { get; set; }
        public string Route { get; set; }
        public int DutyType { get; set; }
        public string DutyTypeTitle { get; set; }
        public Nullable<System.DateTime> STDLocal { get; set; }
        public Nullable<System.DateTime> STALocal { get; set; }
        public Nullable<System.DateTime> DateStartLocal { get; set; }
        public Nullable<System.DateTime> DateEndLocal { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public Nullable<System.DateTime> StartUTC { get; set; }
        public Nullable<System.DateTime> EndUTC { get; set; }
        public string Register { get; set; }
        public string AircraftType { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> DateSent { get; set; }
        public string Ref { get; set; }
        public Nullable<int> ResId { get; set; }
        public string ResStr { get; set; }
        public Nullable<System.DateTime> ResDate { get; set; }
        public string Delivery { get; set; }
        public Nullable<int> SMSId { get; set; }
        public string SMS { get; set; }
        public int OrderIndex { get; set; }
        public Nullable<int> DateStartYear { get; set; }
        public Nullable<int> DateStartMonth { get; set; }
        public Nullable<int> DateStartDay { get; set; }
        public Nullable<System.DateTime> RestUntil { get; set; }
        public Nullable<System.DateTime> RestUntilLocal { get; set; }
        public string Remark2 { get; set; }
        public string InitFlts { get; set; }
        public string InitRoute { get; set; }
        public string CanceledNo { get; set; }
        public string CanceledRoute { get; set; }
        public Nullable<System.DateTime> DateVisit { get; set; }
        public int IsVisited { get; set; }
        public string IsVisitedStr { get; set; }
        public double ExtendedBySplitDuty { get; set; }
        public int IsExtendedBySplitDuty { get; set; }
        public Nullable<double> MaxFDPExtended { get; set; }
        public Nullable<double> DutyScheduled { get; set; }
        public Nullable<double> Duty { get; set; }
        public int IsOver { get; set; }
        public Nullable<int> Extension { get; set; }
        public int IsExtension { get; set; }
        public Nullable<System.DateTime> DateConfirmed { get; set; }
        public string ConfirmedBy { get; set; }
        public int IsConfirmed { get; set; }
        public string UserName { get; set; }
        public Nullable<int> BaseAirportId { get; set; }
        public Nullable<System.DateTime> DateLocal2 { get; set; }
    }
}
