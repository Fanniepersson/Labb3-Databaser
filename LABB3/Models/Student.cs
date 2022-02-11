using System;
using System.Collections.Generic;

namespace LABB3.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Gender { get; set; } = null!;

        public virtual Class Class { get; set; } = null!;
    }
}
