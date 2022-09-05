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
    
    public partial class CourseType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseType()
        {
            this.CourseRelatedCourseTypes = new HashSet<CourseRelatedCourseType>();
            this.Courses = new HashSet<Course>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CalenderTypeId { get; set; }
        public Nullable<int> CourseCategoryId { get; set; }
        public Nullable<int> LicenseResultBasicId { get; set; }
        public string Title { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Interval { get; set; }
        public Nullable<bool> IsGeneral { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> CertificateTypeId { get; set; }
        public Nullable<int> IDX { get; set; }
        public Nullable<int> Mandatory { get; set; }
    
        public virtual CourseCategory CourseCategory { get; set; }
        public virtual LicenseResultBasic LicenseResultBasic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseRelatedCourseType> CourseRelatedCourseTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}