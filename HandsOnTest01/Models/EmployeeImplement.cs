using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class EmployeeImplement
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public string roleName { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }
    }
}
