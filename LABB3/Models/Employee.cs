using System;
using System.Collections.Generic;

namespace LABB3.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Hired { get; set; }
        public int Salary { get; set; }
    }
}
