//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project1_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class cours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cours()
        {
            this.courseDateTimes = new HashSet<courseDateTime>();
            this.professorCourseLists = new HashSet<professorCourseList>();
            this.studentCourseLists = new HashSet<studentCourseList>();
        }
    
        public int courseID { get; set; }
        public string courseDepartment { get; set; }
        public string courseName { get; set; }
        public string courseNumber { get; set; }
        public int courseEnrollment { get; set; }
        public int courseCapacity { get; set; }
        public int courseTime { get; set; }
        public int courseDate { get; set; }
        public int professorID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courseDateTime> courseDateTimes { get; set; }
        public virtual courseDateTime courseDateTime { get; set; }
        public virtual professor professor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<professorCourseList> professorCourseLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studentCourseList> studentCourseLists { get; set; }
    }
}
