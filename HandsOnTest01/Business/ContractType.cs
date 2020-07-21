using System;

namespace Business
{
    public class ContractType:ContractTypeImplement
    {
        public readonly decimal salary;
        public int MonthOfYears { get { return 12; } }

        protected ContractType(){ }
        public ContractType(decimal salary)
        {
            this.salary = salary;
        }
        public virtual decimal AnualSalary()
        {
            return this.salary * this.MonthOfYears;

        }

    }
}
