//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualClasses.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignment
    {
        public Assignment()
        {
            this.Questions = new HashSet<AssignmentQuestion>();
        }
    
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual ICollection<AssignmentQuestion> Questions { get; set; }
    }
}
