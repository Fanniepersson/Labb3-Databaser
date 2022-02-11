using System;
using System.Collections.Generic;

namespace LABB3.Models
{
    public partial class StudCourse
    {
        public int EmployeeId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public byte? Grade { get; set; }
        public DateTime? GradeDate { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
