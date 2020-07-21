using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class MonthlySalaryEmployee :ContractType
    {
        protected MonthlySalaryEmployee():base(){}
        public MonthlySalaryEmployee(decimal salary):base(salary){ }
    }
}
