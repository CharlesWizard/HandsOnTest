using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class HourlySalaryEmployee : ContractType
    {
        //TODO:Renombrar variable segun el significado de la variable.
        public int HoursMonth { get { return 120; } }
        protected HourlySalaryEmployee():base(){}

        public HourlySalaryEmployee(decimal salary):base(salary) {}
        public override decimal AnualSalary()
        {
            return base.AnualSalary() * this.HoursMonth;
        }
    }
}
