﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPAGriffinAPI.Models;
using Newtonsoft.Json.Serialization;
namespace EPAGriffinAPI.ViewModels
{
    public class Person
    {
        public int PersonId { get; set; }
        public DateTime? DateCreate { get; set; }
        public int MarriageId { get; set; }
        public string NID { get; set; }
        public int SexId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile { get; set; }
        public string FaxTelNumber { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? DatePassportIssue { get; set; }
        public DateTime? DatePassportExpire { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public bool OtherAirline { get; set; }
        public DateTime? DateJoinAvation { get; set; }
        public DateTime? DateLastCheckUP { get; set; }
        public DateTime? DateNextCheckUP { get; set; }
        public DateTime? DateYearOfExperience { get; set; }
        public string CaoCardNumber { get; set; }
        public DateTime? DateCaoCardIssue { get; set; }
        public DateTime? DateCaoCardExpire { get; set; }
        public string CompetencyNo { get; set; }
        public int? CaoInterval { get; set; }
        public int? CaoIntervalCalanderTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public string Remark { get; set; }
        public string StampNumber { get; set; }
        public string StampUrl { get; set; }
        public string TechLogNo { get; set; }
        public DateTime? DateIssueNDT { get; set; }
        public int? IntervalNDT { get; set; }
        public string NDTNumber { get; set; }
        public int? NDTIntervalCalanderTypeId { get; set; }
        public bool? IsAuditor { get; set; }
        public bool? IsAuditee { get; set; }
        public string Nickname { get; set; }
        public int? CityId { get; set; }
        public string FatherName { get; set; }
        public string IDNo { get; set; }
        public Nullable<System.Guid> RowId { get; set; }
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> CustomerCreatorId { get; set; }
        public Nullable<System.DateTime> DateExpireNDT { get; set; }


        public DateTime? ProficiencyExpireDate { get; set; }
        public DateTime? CrewMemberCertificateExpireDate { get; set; }
        public DateTime? LicenceExpireDate { get; set; }
        public DateTime? LicenceIRExpireDate { get; set; }
        public DateTime? SimulatorLastCheck { get; set; }
        public DateTime? SimulatorNextCheck { get; set; }
        public string RampPassNo { get; set; }
        public DateTime? RampPassExpireDate { get; set; }
        public DateTime? LanguageCourseExpireDate { get; set; }
        public string LicenceTitle { get; set; }
        public DateTime? LicenceInitialIssue { get; set; }
        public string RaitingCertificates { get; set; }
        public DateTime? LicenceIssueDate { get; set; }
        public string LicenceDescription { get; set; }
        public int? ProficiencyCheckType { get; set; }
        public DateTime? ProficiencyCheckDate { get; set; }
        public DateTime? ProficiencyValidUntil { get; set; }
        public int? ICAOLPRLevel { get; set; }
        public DateTime? ICAOLPRValidUntil { get; set; }
        public int? MedicalClass { get; set; }
        public string CMCEmployedBy { get; set; }
        public string CMCOccupation { get; set; }
        public string PostalCode { get; set; }
        public bool? ProficiencyIPC { get; set; }
        public bool? ProficiencyOPC { get; set; }

        public string MedicalLimitation { get; set; }
        public string ProficiencyDescription { get; set; }

        public DateTime? VisaExpireDate { get; set; }
        public DateTime? SEPTIssueDate { get; set; }
        public DateTime? SEPTExpireDate { get; set; }
        public DateTime? SEPTPIssueDate { get; set; }
        public DateTime? SEPTPExpireDate { get; set; }
        public DateTime? DangerousGoodsIssueDate { get; set; }
        public DateTime? DangerousGoodsExpireDate { get; set; }
        public DateTime? CCRMIssueDate { get; set; }
        public DateTime? CCRMExpireDate { get; set; }
        public DateTime? CRMIssueDate { get; set; }
        public DateTime? CRMExpireDate { get; set; }
        public DateTime? SMSIssueDate { get; set; }
        public DateTime? SMSExpireDate { get; set; }
        public DateTime? AviationSecurityIssueDate { get; set; }
        public DateTime? AviationSecurityExpireDate { get; set; }
        public DateTime? EGPWSIssueDate { get; set; }
        public DateTime? EGPWSExpireDate { get; set; }
        public DateTime? UpsetRecoveryTrainingIssueDate { get; set; }
        public DateTime? UpsetRecoveryTrainingExpireDate { get; set; }
        public DateTime? ColdWeatherOperationIssueDate { get; set; }
        public DateTime? HotWeatherOperationIssueDate { get; set; }

        public DateTime? ColdWeatherOperationExpireDate { get; set; }
        public DateTime? HotWeatherOperationExpireDate { get; set; }


        public DateTime? PBNRNAVIssueDate { get; set; }
        public DateTime? PBNRNAVExpireDate { get; set; }

        public DateTime? FirstAidIssueDate { get; set; }
        public DateTime? FirstAidExpireDate { get; set; }

        public string ScheduleName { get; set; }
        public string Code { get; set; }

        public DateTime? DateTypeIssue { get; set; }
        public DateTime? DateTypeExpire { get; set; }
        public int? AircraftTypeId { get; set; }

        public string ProficiencyDescriptionOPC { get; set; }
        public DateTime? ProficiencyCheckDateOPC { get; set; }
        public DateTime? ProficiencyValidUntilOPC { get; set; }
        public DateTime? DateTRIExpired { get; set; }
        public DateTime? DateTREExpired { get; set; }

        public DateTime? LineIssueDate { get; set; }
        public DateTime? LineExpireDate { get; set; }

        public DateTime? RecurrentIssueDate { get; set; }
        public DateTime? RecurrentExpireDate { get; set; }


        List<PersonEducation> educations = null;
        public List<PersonEducation> Educations
        {
            get
            {
                if (educations == null)
                    educations = new List<PersonEducation>();
                return educations;

            }
            set { educations = value; }
        }

        List<PersonExperiense> expreienses = null;
        public List<PersonExperiense> Expreienses
        {
            get
            {
                if (expreienses == null)
                    expreienses = new List<PersonExperiense>();
                return expreienses;

            }
            set { expreienses = value; }
        }

        List<PersonAircraftType> aircraftTypes = null;
        public List<PersonAircraftType> AircraftTypes
        {
            get
            {
                if (aircraftTypes == null)
                    aircraftTypes = new List<PersonAircraftType>();
                return aircraftTypes;

            }
            set { aircraftTypes = value; }
        }

        //ViewCertificate
        List<ViewCertificate> certificates = null;
        public List<ViewCertificate> Certificates
        {
            get
            {
                if (certificates == null)
                    certificates = new List<ViewCertificate>();
                return certificates;

            }
            set { certificates = value; }
        }

        
            List<ViewPersonActiveCourse> courses = null;
        public List<ViewPersonActiveCourse> Courses
        {
            get
            {
                if (courses == null)
                    courses = new List<ViewPersonActiveCourse>();
                return courses;

            }
            set { courses = value; }
        }




        List<PersonDocument> documents = null;
        public List<PersonDocument> Documents
        {
            get
            {
                if (documents == null)
                    documents = new List<PersonDocument>();
                return documents;

            }
            set { documents = value; }
        }

        List<PersonRating> ratings = null;
        public List<PersonRating> Ratings
        {
            get
            {
                if (ratings == null)
                    ratings = new List<PersonRating>();
                return ratings;

            }
            set { ratings = value; }
        }

        public static void Fill(Models.Person entity, ViewModels.Person person)
        {
            if (person.DateTypeIssue != null)
            {
                person.DateTypeIssue = ((DateTime)person.DateTypeIssue).ToLocalTime();
            }
            if (person.DateTypeExpire != null)
            {
                
                person.DateTypeExpire = ((DateTime)person.DateTypeExpire).ToLocalTime();
            }
            entity.Id = person.PersonId;
            entity.AircraftTypeId = person.AircraftTypeId;
            entity.DateTypeIssue = person.DateTypeIssue;
            entity.DateTypeExpire = person.DateTypeExpire;

            //    entity.DateCreate = person.DateCreate;
            entity.MarriageId = person.MarriageId;
            entity.NID = person.NID;
            entity.SexId = person.SexId;
            entity.FirstName = person.FirstName;
            entity.LastName = person.LastName;
            entity.DateBirth = person.DateBirth;
            entity.Email = person.Email;
            entity.EmailPassword = person.EmailPassword;
            entity.Phone1 = person.Phone1;
            entity.Phone2 = person.Phone2;
            entity.Mobile = person.Mobile;
            entity.FaxTelNumber = person.FaxTelNumber;
            entity.PassportNumber = person.PassportNumber;
            entity.DatePassportIssue = person.DatePassportIssue;
            entity.DatePassportExpire = person.DatePassportExpire;
            entity.Address = person.Address;
            entity.IsActive = person.IsActive;
            entity.DateJoinAvation = person.DateJoinAvation;
            entity.DateLastCheckUP = person.DateLastCheckUP==null?null: (Nullable<DateTime>)((DateTime)person.DateLastCheckUP).Date;
            entity.DateNextCheckUP = person.DateNextCheckUP==null?null:(Nullable<DateTime>)((DateTime)person.DateNextCheckUP).Date. AddHours(23).AddMinutes(59).AddSeconds(59);
            entity.DateYearOfExperience = person.DateYearOfExperience;
            entity.CaoCardNumber = person.CaoCardNumber;
            entity.DateCaoCardIssue = person.DateCaoCardIssue;
            entity.DateCaoCardExpire = person.DateCaoCardExpire;
            entity.CompetencyNo = person.CompetencyNo;
            entity.CaoInterval = person.CaoInterval;
            entity.CaoIntervalCalanderTypeId = person.CaoIntervalCalanderTypeId;
            entity.IsDeleted = person.IsDeleted;
            entity.Remark = person.Remark;
            entity.StampNumber = person.StampNumber;
            entity.StampUrl = person.StampUrl;
            entity.TechLogNo = person.TechLogNo;
            entity.DateIssueNDT = person.DateIssueNDT;
            entity.IntervalNDT = person.IntervalNDT;
            entity.NDTNumber = person.NDTNumber;
            entity.NDTIntervalCalanderTypeId = person.NDTIntervalCalanderTypeId;
            entity.IsAuditor = person.IsAuditor;
            entity.IsAuditee = person.IsAuditee;
            entity.Nickname = person.Nickname;
            entity.CityId = person.CityId;
            entity.FatherName = person.FatherName;
            entity.IDNo = person.IDNo;
            entity.ImageUrl = person.ImageUrl;

            entity.ProficiencyExpireDate = person.ProficiencyExpireDate;
            entity.CrewMemberCertificateExpireDate = person.CrewMemberCertificateExpireDate;
            entity.LicenceExpireDate = person.LicenceExpireDate;
            entity.LicenceIRExpireDate = person.LicenceIRExpireDate;
            entity.SimulatorLastCheck = person.SimulatorLastCheck;
            entity.SimulatorNextCheck = person.SimulatorNextCheck;
            entity.RampPassNo = person.RampPassNo;
            entity.RampPassExpireDate = person.RampPassExpireDate;
            entity.LanguageCourseExpireDate = person.LanguageCourseExpireDate;
            entity.LicenceTitle = person.LicenceTitle;
            entity.LicenceInitialIssue = person.LicenceInitialIssue;
            entity.RaitingCertificates = person.RaitingCertificates;
            entity.LicenceIssueDate = person.LicenceIssueDate;
            entity.LicenceDescription = person.LicenceDescription;
            entity.ProficiencyCheckType = person.ProficiencyCheckType;
            entity.ProficiencyCheckDate = person.ProficiencyCheckDate;
            entity.ProficiencyValidUntil = person.ProficiencyValidUntil;
            entity.ICAOLPRLevel = person.ICAOLPRLevel;
            entity.ICAOLPRValidUntil = person.ICAOLPRValidUntil;
            entity.MedicalClass = person.MedicalClass;
            entity.CMCEmployedBy = person.CMCEmployedBy;
            entity.CMCOccupation = person.CMCOccupation;
            entity.PostalCode = person.PostalCode;
            entity.ProficiencyIPC = person.ProficiencyIPC;
            entity.ProficiencyOPC = person.ProficiencyOPC;
            entity.VisaExpireDate = person.VisaExpireDate;
            entity.MedicalLimitation = person.MedicalLimitation;
            entity.ProficiencyExpireDate = person.ProficiencyExpireDate;
            entity.SEPTIssueDate = person.SEPTIssueDate;
            entity.SEPTExpireDate = person.SEPTExpireDate;
            entity.SEPTPIssueDate = person.SEPTPIssueDate;
            entity.SEPTPExpireDate = person.SEPTPExpireDate;
            entity.DangerousGoodsIssueDate = person.DangerousGoodsIssueDate;
            entity.DangerousGoodsExpireDate = person.DangerousGoodsExpireDate;
            entity.CCRMIssueDate = person.CCRMIssueDate;
            entity.CCRMExpireDate = person.CCRMExpireDate;
            entity.CRMIssueDate = person.CRMIssueDate;
            entity.CRMExpireDate = person.CRMExpireDate;
            entity.SMSIssueDate = person.SMSIssueDate;
            entity.SMSExpireDate = person.SMSExpireDate;
            entity.AviationSecurityIssueDate = person.AviationSecurityIssueDate;
            entity.AviationSecurityExpireDate = person.AviationSecurityExpireDate;
            entity.EGPWSIssueDate = person.EGPWSIssueDate;
            entity.EGPWSExpireDate = person.EGPWSExpireDate;
            entity.UpsetRecoveryTrainingIssueDate = person.UpsetRecoveryTrainingIssueDate;
            entity.UpsetRecoveryTrainingExpireDate = person.UpsetRecoveryTrainingExpireDate;
            entity.ColdWeatherOperationIssueDate = person.ColdWeatherOperationIssueDate;
            entity.HotWeatherOperationIssueDate = person.HotWeatherOperationIssueDate;
            entity.ColdWeatherOperationExpireDate = person.ColdWeatherOperationExpireDate;
            entity.HotWeatherOperationExpireDate = person.HotWeatherOperationExpireDate;
            entity.PBNRNAVIssueDate = person.PBNRNAVIssueDate;
            entity.PBNRNAVExpireDate = person.PBNRNAVExpireDate;

            entity.FirstAidExpireDate = person.FirstAidExpireDate;
            entity.FirstAidIssueDate = person.FirstAidIssueDate;
            entity.ScheduleName = person.ScheduleName;
            if (string.IsNullOrEmpty(entity.ScheduleName))
                entity.ScheduleName = entity.FirstName + entity.LastName;
            entity.Code = person.Code;

            entity.DateTREExpired = person.DateTREExpired;
            entity.DateTRIExpired = person.DateTRIExpired;
            entity.ProficiencyCheckDateOPC = person.ProficiencyCheckDateOPC;
            entity.ProficiencyDescriptionOPC = person.ProficiencyDescriptionOPC;
            entity.ProficiencyValidUntilOPC = person.ProficiencyValidUntilOPC;

            entity.LineIssueDate = person.LineIssueDate;
            entity.LineExpireDate = person.LineExpireDate;

            entity.RecurrentIssueDate = person.RecurrentIssueDate;
            entity.RecurrentExpireDate = person.RecurrentExpireDate;

            entity.OtherAirline = person.OtherAirline;



        }
        public static void FillDto(Models.Person entity, ViewModels.Person person)
        {
            person.PersonId = entity.Id;
            person.DateCreate = entity.DateCreate;
            person.MarriageId = entity.MarriageId;
            person.NID = entity.NID;
            person.SexId = entity.SexId;
            person.FirstName = entity.FirstName;
            person.LastName = entity.LastName;
            person.DateBirth = entity.DateBirth;
            person.Email = entity.Email;
            person.EmailPassword = entity.EmailPassword;
            person.Phone1 = entity.Phone1;
            person.Phone2 = entity.Phone2;
            person.Mobile = entity.Mobile;
            person.FaxTelNumber = entity.FaxTelNumber;
            person.PassportNumber = entity.PassportNumber;
            person.DatePassportIssue = entity.DatePassportIssue;
            person.DatePassportExpire = entity.DatePassportExpire;
            person.Address = entity.Address;
            person.IsActive = entity.IsActive;
            person.DateJoinAvation = entity.DateJoinAvation;
            person.DateLastCheckUP = entity.DateLastCheckUP;
            person.DateNextCheckUP = entity.DateNextCheckUP;
            person.DateYearOfExperience = entity.DateYearOfExperience;
            person.CaoCardNumber = entity.CaoCardNumber;
            person.DateCaoCardIssue = entity.DateCaoCardIssue;
            person.DateCaoCardExpire = entity.DateCaoCardExpire;
            person.CompetencyNo = entity.CompetencyNo;
            person.CaoInterval = entity.CaoInterval;
            person.CaoIntervalCalanderTypeId = entity.CaoIntervalCalanderTypeId;
            person.IsDeleted = entity.IsDeleted;
            person.Remark = entity.Remark;
            person.StampNumber = entity.StampNumber;
            person.StampUrl = entity.StampUrl;
            person.TechLogNo = entity.TechLogNo;
            person.DateIssueNDT = entity.DateIssueNDT;
            person.IntervalNDT = entity.IntervalNDT;
            person.NDTNumber = entity.NDTNumber;
            person.NDTIntervalCalanderTypeId = entity.NDTIntervalCalanderTypeId;
            person.IsAuditor = entity.IsAuditor;
            person.IsAuditee = entity.IsAuditee;
            person.Nickname = entity.Nickname;
            person.CityId = entity.CityId;
            person.FatherName = entity.FatherName;
            person.IDNo = entity.IDNo;
            person.RowId = entity.RowId;
            person.UserId = entity.UserId;
            person.ImageUrl = entity.ImageUrl;
            person.CustomerCreatorId = entity.CustomerCreatorId;
            person.DateExpireNDT = entity.DateExpireNDT;

            person.ProficiencyExpireDate = entity.ProficiencyExpireDate;
            person.CrewMemberCertificateExpireDate = entity.CrewMemberCertificateExpireDate;
            person.LicenceExpireDate = entity.LicenceExpireDate;
            person.LicenceIRExpireDate = entity.LicenceIRExpireDate;
            person.SimulatorLastCheck = entity.SimulatorLastCheck;
            person.SimulatorNextCheck = entity.SimulatorNextCheck;
            person.RampPassNo = entity.RampPassNo;
            person.RampPassExpireDate = entity.RampPassExpireDate;
            person.LanguageCourseExpireDate = entity.LanguageCourseExpireDate;
            person.LicenceTitle = entity.LicenceTitle;
            person.LicenceInitialIssue = entity.LicenceInitialIssue;
            person.RaitingCertificates = entity.RaitingCertificates;
            person.LicenceIssueDate = entity.LicenceIssueDate;
            person.LicenceDescription = entity.LicenceDescription;
            person.ProficiencyCheckType = entity.ProficiencyCheckType;
            person.ProficiencyCheckDate = entity.ProficiencyCheckDate;
            person.ProficiencyValidUntil = entity.ProficiencyValidUntil;
            person.ICAOLPRLevel = entity.ICAOLPRLevel;
            person.ICAOLPRValidUntil = entity.ICAOLPRValidUntil;
            person.MedicalClass = entity.MedicalClass;
            person.CMCEmployedBy = entity.CMCEmployedBy;
            person.CMCOccupation = entity.CMCOccupation;
            person.PostalCode = entity.PostalCode;
            person.ProficiencyIPC = entity.ProficiencyIPC;
            person.ProficiencyOPC = entity.ProficiencyOPC;

            person.MedicalLimitation = entity.MedicalLimitation;
            person.ProficiencyDescription = entity.ProficiencyDescription;
            person.VisaExpireDate = entity.VisaExpireDate;

            person.SEPTIssueDate = entity.SEPTIssueDate;
            person.SEPTExpireDate = entity.SEPTExpireDate;
            person.SEPTPIssueDate = entity.SEPTPIssueDate;
            person.SEPTPExpireDate = entity.SEPTPExpireDate;
            person.DangerousGoodsIssueDate = entity.DangerousGoodsIssueDate;
            person.DangerousGoodsExpireDate = entity.DangerousGoodsExpireDate;
            person.CCRMIssueDate = entity.CCRMIssueDate;
            person.CCRMExpireDate = entity.CCRMExpireDate;
            person.CRMIssueDate = entity.CRMIssueDate;
            person.CRMExpireDate = entity.CRMExpireDate;
            person.SMSIssueDate = entity.SMSIssueDate;
            person.SMSExpireDate = entity.SMSExpireDate;
            person.AviationSecurityIssueDate = entity.AviationSecurityIssueDate;
            person.AviationSecurityExpireDate = entity.AviationSecurityExpireDate;
            person.EGPWSIssueDate = entity.EGPWSIssueDate;
            person.EGPWSExpireDate = entity.EGPWSExpireDate;
            person.UpsetRecoveryTrainingIssueDate = entity.UpsetRecoveryTrainingIssueDate;
            person.UpsetRecoveryTrainingExpireDate = entity.UpsetRecoveryTrainingExpireDate;
            person.ColdWeatherOperationIssueDate = entity.ColdWeatherOperationIssueDate;
            person.HotWeatherOperationIssueDate = entity.HotWeatherOperationIssueDate;
            person.ColdWeatherOperationExpireDate = entity.ColdWeatherOperationExpireDate;
            person.HotWeatherOperationExpireDate = entity.HotWeatherOperationExpireDate;
            person.PBNRNAVIssueDate = entity.PBNRNAVIssueDate;
            person.PBNRNAVExpireDate = entity.PBNRNAVExpireDate;
            person.FirstAidExpireDate = entity.FirstAidExpireDate;
            person.FirstAidIssueDate = entity.FirstAidIssueDate;
            person.ScheduleName = entity.ScheduleName;
            person.Code = entity.Code;
            person.AircraftTypeId = entity.AircraftTypeId;
            person.DateTypeExpire = entity.DateTypeExpire;
            person.DateTypeIssue = entity.DateTypeIssue;

            person.ProficiencyCheckDateOPC = entity.ProficiencyCheckDateOPC;
            person.ProficiencyValidUntilOPC = entity.ProficiencyValidUntilOPC;
            person.ProficiencyDescriptionOPC = entity.ProficiencyDescriptionOPC;

            person.DateTRIExpired = entity.DateTRIExpired;
            person.DateTREExpired = entity.DateTREExpired;

            person.LineExpireDate = entity.LineExpireDate;
            person.LineIssueDate = entity.LineIssueDate;
            person.RecurrentExpireDate = entity.RecurrentExpireDate;
            person.RecurrentIssueDate = entity.RecurrentIssueDate;

            person.OtherAirline = entity.OtherAirline==null?false:(bool)entity.OtherAirline;

        }
    }

    public partial class PersonAircraftType
    {
        public string AircraftType { get; set; }
        public int ManufacturerId { get; set; }
        public string Manufacturer { get; set; }
        public int Id { get; set; }
        public int AircraftTypeId { get; set; }
        public int PersonId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> DateLimitBegin { get; set; }
        public Nullable<System.DateTime> DateLimitEnd { get; set; }
        public string Remark { get; set; }
        public static void Fill(Models.PersonAircraftType entity, ViewModels.PersonAircraftType personaircrafttype)
        {
            entity.Id = personaircrafttype.Id;
            entity.AircraftTypeId = personaircrafttype.AircraftTypeId;
            entity.PersonId = personaircrafttype.PersonId;
            entity.IsActive = personaircrafttype.IsActive;
            entity.DateLimitBegin = personaircrafttype.DateLimitBegin;
            entity.DateLimitEnd = personaircrafttype.DateLimitEnd;
            entity.Remark = personaircrafttype.Remark;
        }
        public static void FillDto(Models.ViewPersonAircraftType entity, ViewModels.PersonAircraftType viewpersonaircrafttype)
        {
            viewpersonaircrafttype.AircraftType = entity.AircraftType;
            viewpersonaircrafttype.ManufacturerId = entity.ManufacturerId;
            viewpersonaircrafttype.Manufacturer = entity.Manufacturer;
            viewpersonaircrafttype.Id = entity.Id;
            viewpersonaircrafttype.AircraftTypeId = entity.AircraftTypeId;
            viewpersonaircrafttype.PersonId = entity.PersonId;
            viewpersonaircrafttype.IsActive = entity.IsActive;
            viewpersonaircrafttype.DateLimitBegin = entity.DateLimitBegin;
            viewpersonaircrafttype.DateLimitEnd = entity.DateLimitEnd;
            viewpersonaircrafttype.Remark = entity.Remark;
        }
        public static ViewModels.PersonAircraftType GetDto(Models.ViewPersonAircraftType entity)
        {
            var result = new ViewModels.PersonAircraftType();
            FillDto(entity, result);
            return result;
        }
        public static List<ViewModels.PersonAircraftType> GetDtos(List<Models.ViewPersonAircraftType> entities)
        {
            var result = new List<ViewModels.PersonAircraftType>();
            foreach (var x in entities)
                result.Add(GetDto(x));
            return result;

        }
    }

    public partial class PersonDocument
    {
        public int PersonId { get; set; }
        public string Title { get; set; }
        public string Remark { get; set; }
        public int DocumentTypeId { get; set; }
        public int Id { get; set; }
        public string DocumentType { get; set; }
        List<Document> documents = null;
        public List<Document> Documents
        {
            get
            {
                if (documents == null)
                    documents = new List<Document>();
                return documents;

            }
            set { documents = value; }
        }
        public static void Fill(Models.ViewPersonDocument entity, ViewModels.PersonDocument viewpersondocument)
        {


            entity.PersonId = viewpersondocument.PersonId;
            entity.Title = viewpersondocument.Title;
            entity.Remark = viewpersondocument.Remark;
            entity.DocumentTypeId = viewpersondocument.DocumentTypeId;
            entity.Id = viewpersondocument.Id;
            entity.DocumentType = viewpersondocument.DocumentType;
        }
        public static void FillDto(Models.ViewPersonDocument entity, ViewModels.PersonDocument viewpersondocument)
        {
            viewpersondocument.PersonId = entity.PersonId;
            viewpersondocument.Title = entity.Title;
            viewpersondocument.Remark = entity.Remark;
            viewpersondocument.DocumentTypeId =(int) entity.DocumentTypeId;
            viewpersondocument.Id = entity.Id;
            viewpersondocument.DocumentType = entity.DocumentType;
        }

        public static ViewModels.PersonDocument GetDto(Models.ViewPersonDocument entity, List<Models.ViewPersonDocumentFile> files)
        {
            var result = new ViewModels.PersonDocument();
            FillDto(entity, result);
            var docfiles = files.Where(q => q.PersonDocumentId == entity.Id).ToList();
            foreach (var x in docfiles)
            {
                result.Documents.Add(new Document()
                {
                    DocumentTypeId = x.DocumentTypeId,
                    FileType = x.FileType,
                    FileTypeId = x.FileTypeId,
                    FileUrl = x.FileUrl,
                    Id = x.Id,
                    SysUrl = x.SysUrl,
                    Title = x.Title,

                });
            }
            return result;
        }
        public static List<ViewModels.PersonDocument> GetDtos(List<Models.ViewPersonDocument> entities, List<Models.ViewPersonDocumentFile> files)
        {
            var result = new List<ViewModels.PersonDocument>();
            foreach (var x in entities)
                result.Add(GetDto(x, files));
            return result;

        }
    }
    public partial class PersonEducation
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int EducationDegreeId { get; set; }
        public Nullable<System.DateTime> DateCatch { get; set; }
        public string College { get; set; }
        public string Remark { get; set; }
        public string Title { get; set; }
        public int StudyFieldId { get; set; }
        public string StudyField { get; set; }
        public string EducationDegree { get; set; }
        public string FileTitle { get; set; }
        public string FileType { get; set; }
        public string FileUrl { get; set; }
        public string SysUrl { get; set; }
        public static void Fill(Models.PersonEducation entity, ViewModels.PersonEducation personeducation)
        {
            entity.Id = personeducation.Id;
            entity.PersonId = personeducation.PersonId;
            entity.EducationDegreeId = personeducation.EducationDegreeId;
            entity.DateCatch = personeducation.DateCatch;
            entity.College = personeducation.College;
            entity.Remark = personeducation.Remark;
            entity.Title = personeducation.Title;
            entity.StudyFieldId = personeducation.StudyFieldId;
            entity.FileTitle = personeducation.FileTitle;
            entity.FileUrl = personeducation.FileUrl;
            entity.SysUrl = personeducation.SysUrl;
            entity.FileType = personeducation.FileType;
        }
        public static void FillDto(Models.ViewPersonEducation entity, ViewModels.PersonEducation viewpersoneducation)
        {
            viewpersoneducation.Id = entity.Id;
            viewpersoneducation.PersonId = entity.PersonId;
            viewpersoneducation.EducationDegreeId = entity.EducationDegreeId;
            viewpersoneducation.DateCatch = entity.DateCatch;
            viewpersoneducation.College = entity.College;
            viewpersoneducation.Remark = entity.Remark;
            viewpersoneducation.Title = entity.Title;
            viewpersoneducation.StudyFieldId = entity.StudyFieldId;
            viewpersoneducation.StudyField = entity.StudyField;
            viewpersoneducation.EducationDegree = entity.EducationDegree;

            viewpersoneducation.FileTitle = entity.FileTitle;
            viewpersoneducation.FileUrl = entity.FileUrl;
            viewpersoneducation.SysUrl = entity.SysUrl;
            viewpersoneducation.FileType = entity.FileType;
        }
        public static ViewModels.PersonEducation GetDto(Models.ViewPersonEducation entity)
        {
            var result = new ViewModels.PersonEducation();
            FillDto(entity, result);
            return result;
        }
        public static List<ViewModels.PersonEducation> GetDtos(List<Models.ViewPersonEducation> entities)
        {
            var result = new List<ViewModels.PersonEducation>();
            foreach (var x in entities)
                result.Add(GetDto(x));
            return result;

        }
    }
    public partial class PersonExperiense
    {
        public int PersonId { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public string Employer { get; set; }
        public Nullable<int> AircraftTypeId { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string Organization { get; set; }
        public string JobTitle { get; set; }
        public string AircraftType { get; set; }
        public int Id { get; set; }
        public static void Fill(Models.PersonExperiense entity, ViewModels.PersonExperiense personexperiense)
        {
            entity.Id = personexperiense.Id;
            entity.PersonId = personexperiense.PersonId;
            entity.OrganizationId = personexperiense.OrganizationId;
            entity.Employer = personexperiense.Employer;
            entity.AircraftTypeId = personexperiense.AircraftTypeId;
            entity.Remark = personexperiense.Remark;
            entity.JobTitle = personexperiense.JobTitle;
            entity.DateStart = personexperiense.DateStart;
            entity.DateEnd = personexperiense.DateEnd;
            entity.Organization = personexperiense.Organization;
        }
        public static void FillDto(Models.ViewPersonExperiense entity, ViewModels.PersonExperiense viewpersonexperiense)
        {
            viewpersonexperiense.PersonId = entity.PersonId;
            viewpersonexperiense.OrganizationId = entity.OrganizationId;
            viewpersonexperiense.Employer = entity.Employer;
            viewpersonexperiense.AircraftTypeId = entity.AircraftTypeId;
            viewpersonexperiense.Remark = entity.Remark;
            viewpersonexperiense.DateStart = entity.DateStart;
            viewpersonexperiense.DateEnd = entity.DateEnd;
            viewpersonexperiense.Organization = entity.Organization;
            viewpersonexperiense.JobTitle = entity.JobTitle;
            viewpersonexperiense.AircraftType = entity.AircraftType;
            viewpersonexperiense.Id = entity.Id;
        }
        public static ViewModels.PersonExperiense GetDto(Models.ViewPersonExperiense entity)
        {
            var result = new ViewModels.PersonExperiense();
            FillDto(entity, result);
            return result;
        }
        public static List<ViewModels.PersonExperiense> GetDtos(List<Models.ViewPersonExperiense> entities)
        {
            var result = new List<ViewModels.PersonExperiense>();
            foreach (var x in entities)
                result.Add(GetDto(x));
            return result;

        }
    }
    public partial class PersonRating
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int AircraftTypeId { get; set; }
        public int? RatingId { get; set; }
        public DateTime DateIssue { get; set; }
        public DateTime? DateExpire { get; set; }
        public int? CategoryId { get; set; }
        public string AircraftType { get; set; }
        public string RatingOrganization { get; set; }
        public int? OrganizationId { get; set; }
        public string Category { get; set; }
        public static void Fill(Models.ViewPersonRating entity, ViewModels.PersonRating viewpersonrating)
        {
            entity.Id = viewpersonrating.Id;
            entity.PersonId = viewpersonrating.PersonId;
            entity.AircraftTypeId = viewpersonrating.AircraftTypeId;
            entity.RatingId = viewpersonrating.RatingId;
            entity.DateIssue = viewpersonrating.DateIssue;
            entity.DateExpire = viewpersonrating.DateExpire;
            entity.CategoryId = viewpersonrating.CategoryId;
            entity.AircraftType = viewpersonrating.AircraftType;
            entity.RatingOrganization = viewpersonrating.RatingOrganization;
            entity.OrganizationId = viewpersonrating.OrganizationId;
            entity.Category = viewpersonrating.Category;
        }
        public static void FillDto(Models.ViewPersonRating entity, ViewModels.PersonRating viewpersonrating)
        {
            viewpersonrating.Id = entity.Id;
            viewpersonrating.PersonId = entity.PersonId;
            viewpersonrating.AircraftTypeId = entity.AircraftTypeId;
            viewpersonrating.RatingId = entity.RatingId;
            viewpersonrating.DateIssue = entity.DateIssue;
            viewpersonrating.DateExpire = entity.DateExpire;
            viewpersonrating.CategoryId = entity.CategoryId;
            viewpersonrating.AircraftType = entity.AircraftType;
            viewpersonrating.RatingOrganization = entity.RatingOrganization;
            viewpersonrating.OrganizationId = entity.OrganizationId;
            viewpersonrating.Category = entity.Category;
        }
        public static ViewModels.PersonRating GetDto(Models.ViewPersonRating entity)
        {
            var result = new ViewModels.PersonRating();
            FillDto(entity, result);
            return result;
        }
        public static List<ViewModels.PersonRating> GetDtos(List<Models.ViewPersonRating> entities)
        {
            var result = new List<ViewModels.PersonRating>();
            foreach (var x in entities)
                result.Add(GetDto(x));
            return result;

        }
    }

    public class PersonMiscellaneous
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Remark { get; set; }
        public int TypeId { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Telegram { get; set; }
        public string LinkedIn { get; set; }
        public string Website { get; set; }
        public string Tel { get; set; }
        public static void Fill(Models.PersonMisc entity, ViewModels.PersonMiscellaneous personmisc)
        {
            entity.Id = personmisc.Id;
            entity.FirstName = personmisc.FirstName;
            entity.LastName = personmisc.LastName;
            entity.Remark = personmisc.Remark;
            entity.TypeId = personmisc.TypeId;
            entity.ImageUrl = personmisc.ImageUrl;
            entity.Email = personmisc.Email;
            entity.Instagram = personmisc.Instagram;
            entity.Telegram = personmisc.Telegram;
            entity.LinkedIn = personmisc.LinkedIn;
            entity.Website = personmisc.Website;
            entity.Tel = personmisc.Tel;
        }
        public static void FillDto(Models.PersonMisc entity, ViewModels.PersonMiscellaneous personmisc)
        {
            personmisc.Id = entity.Id;
            personmisc.FirstName = entity.FirstName;
            personmisc.LastName = entity.LastName;
            personmisc.Remark = entity.Remark;
            personmisc.TypeId = entity.TypeId;

            personmisc.ImageUrl = entity.ImageUrl;
            personmisc.Email = entity.Email;
            personmisc.Instagram = entity.Instagram;
            personmisc.Telegram = entity.Telegram;
            personmisc.LinkedIn = entity.LinkedIn;
            personmisc.Website = entity.Website;
            personmisc.Tel = entity.Tel;
        }
    }

    public class TrainingCard
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Rank { get; set; }

        public string IdNo { get; set; }
        public DateTime? BirthDate { get; set; }

        public string BirthDateStr { get; set; }

        public List<TrianingCardCourse> Items { get; set; }

        public string ImageUrl { get; set; }
        public string NID { get; set; }
    }

    public class TrianingCardCourse
    {
        public string Title { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public DateTime? Date3 { get; set; }
        public DateTime? Date4 { get; set; }
        public DateTime? Approved { get; set; }
    }


}