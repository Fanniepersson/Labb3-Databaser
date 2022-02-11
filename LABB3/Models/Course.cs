using System;
using System.Collections.Generic;

namespace LABB3.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
