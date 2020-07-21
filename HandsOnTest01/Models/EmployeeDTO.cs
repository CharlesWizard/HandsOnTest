using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class EmployeeDTO: EmployeeImplement
    {
        public EmployeeDTO() { }
        public decimal AnualSalary { get; set; }
    }
}
