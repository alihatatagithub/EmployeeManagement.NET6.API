using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public partial class TblEmployee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? EmpEmail { get; set; }
        public string? EmpAddress { get; set; }
        public string? EmpPhone { get; set; }
    }
}
