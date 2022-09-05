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
    
    public partial class EFBASR
    {
        public int FlightId { get; set; }
        public Nullable<int> EventTypeId { get; set; }
        public Nullable<System.DateTime> OccurrenceDate { get; set; }
        public Nullable<bool> IsDay { get; set; }
        public string SQUAWK { get; set; }
        public Nullable<decimal> FuelJettisoned { get; set; }
        public Nullable<decimal> Altitude { get; set; }
        public Nullable<double> Speed { get; set; }
        public Nullable<decimal> ACWeight { get; set; }
        public string TechLogPageNO { get; set; }
        public string TechLogItemNO { get; set; }
        public Nullable<int> FlightPhaseId { get; set; }
        public string LOCAirport { get; set; }
        public string LOCStand { get; set; }
        public string LOCRunway { get; set; }
        public string LOCGEOLongtitude { get; set; }
        public string LOCGEOAltitude { get; set; }
        public Nullable<int> METId { get; set; }
        public string ActualWX { get; set; }
        public Nullable<int> SigxWXId { get; set; }
        public Nullable<int> RunwayConditionId { get; set; }
        public string ACConfigAP { get; set; }
        public string ACConfigATHR { get; set; }
        public string ACConfigGear { get; set; }
        public string ACConfigFlap { get; set; }
        public string ACConfigSlat { get; set; }
        public string ACConfigSpoilers { get; set; }
        public string Summary { get; set; }
        public string Result { get; set; }
        public string OthersInfo { get; set; }
        public Nullable<int> AATRiskId { get; set; }
        public Nullable<bool> AATIsActionTaken { get; set; }
        public string AATReportedToATC { get; set; }
        public string AATATCInstruction { get; set; }
        public string AATFrequency { get; set; }
        public Nullable<decimal> AATHeading { get; set; }
        public string AATClearedAltitude { get; set; }
        public string AATMinVerticalSep { get; set; }
        public string AATMinHorizontalSep { get; set; }
        public Nullable<int> AATTCASAlertId { get; set; }
        public string AATTypeRA { get; set; }
        public Nullable<bool> AATIsRAFollowed { get; set; }
        public string AATVerticalDeviation { get; set; }
        public string AATOtherACType { get; set; }
        public string AATMarkingColour { get; set; }
        public string AATCallSign { get; set; }
        public string AATLighting { get; set; }
        public Nullable<decimal> WTHeading { get; set; }
        public Nullable<int> WTTurningId { get; set; }
        public Nullable<int> WTGlideSlopePosId { get; set; }
        public Nullable<int> WTExtendedCenterlinePosId { get; set; }
        public Nullable<int> WTAttitudeChangeId { get; set; }
        public Nullable<decimal> WTAttitudeChangeDeg { get; set; }
        public Nullable<bool> WTIsBuffet { get; set; }
        public Nullable<bool> WTIsStickShaker { get; set; }
        public string WTSuspect { get; set; }
        public string WTDescribeVA { get; set; }
        public string WTPrecedingAC { get; set; }
        public Nullable<bool> WTIsAware { get; set; }
        public string BSBirdType { get; set; }
        public Nullable<int> BSNrSeenId { get; set; }
        public Nullable<int> BSNrStruckId { get; set; }
        public Nullable<int> BSTimeId { get; set; }
        public Nullable<System.DateTime> PICDate { get; set; }
        public int Id { get; set; }
        public Nullable<int> DayNightStatusId { get; set; }
        public Nullable<int> IncidentTypeId { get; set; }
        public Nullable<int> AATXAbove { get; set; }
        public Nullable<int> AATYAbove { get; set; }
        public Nullable<int> AATXAstern { get; set; }
        public Nullable<int> AATYAstern { get; set; }
        public Nullable<int> AATHorizontalPlane { get; set; }
        public string BSImpactDec { get; set; }
        public Nullable<bool> IsSecurityEvent { get; set; }
        public Nullable<bool> IsAirproxATC { get; set; }
        public Nullable<bool> IsTCASRA { get; set; }
        public Nullable<bool> IsWakeTur { get; set; }
        public Nullable<bool> IsBirdStrike { get; set; }
        public Nullable<bool> IsOthers { get; set; }
        public Nullable<double> MachNo { get; set; }
        public Nullable<int> SigxWXTypeId { get; set; }
        public Nullable<double> BSHeading { get; set; }
        public Nullable<int> BSTurningId { get; set; }
        public string DateUpdate { get; set; }
        public string User { get; set; }
        public string JLSignedBy { get; set; }
        public Nullable<System.DateTime> JLDatePICApproved { get; set; }
        public Nullable<int> PICId { get; set; }
        public string PIC { get; set; }
        public string OPSRemark { get; set; }
        public Nullable<System.DateTime> OPSRemarkDate { get; set; }
        public Nullable<int> OPSId { get; set; }
        public Nullable<System.DateTime> OPSConfirmDate { get; set; }
        public string OPSStaffRemark { get; set; }
        public Nullable<System.DateTime> OPSStaffDateVisit { get; set; }
        public Nullable<System.DateTime> OPSStaffConfirmDate { get; set; }
        public Nullable<int> OPSStaffId { get; set; }
        public Nullable<System.DateTime> OPSStaffRemarkDate { get; set; }
        public string OPSUser { get; set; }
        public string OPSStaffUser { get; set; }
        public Nullable<int> OPSStatusId { get; set; }
        public Nullable<int> OPSStaffStatusId { get; set; }
    
        public virtual FlightInformation FlightInformation { get; set; }
    }
}
