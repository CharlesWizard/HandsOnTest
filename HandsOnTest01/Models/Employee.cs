using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee : EmployeeImplement
    {
        public Employee(){}
        public int roleId { get; set; }
        public string roleDescription { get; set; }
        
    }
}
