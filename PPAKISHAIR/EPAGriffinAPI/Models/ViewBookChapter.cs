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
    
    public partial class ViewBookChapter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Remark { get; set; }
        public string Code { get; set; }
        public string Fullcode { get; set; }
        public Nullable<int> BookId { get; set; }
        public string BookKey { get; set; }
        public string TitleFormated { get; set; }
        public string TitleFormatedSpace { get; set; }
        public Nullable<int> Files { get; set; }
    }
}