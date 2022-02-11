using System;
using System.Collections.Generic;

namespace LABB3.Models
{
    public partial class DepEmp
    {
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
    }
}
