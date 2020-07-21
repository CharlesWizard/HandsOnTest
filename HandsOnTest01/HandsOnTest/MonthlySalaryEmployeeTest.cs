using Business;
using System;
using Xunit;

namespace HandsOnTest
{
    public class MonthlySalaryEmployeeTest
    {
        [Fact]
        public void AnualSalary_When_MonthlySalaryEmployee_Has_Value()
        {
            decimal anualSalary = 960000;
            decimal salary = 80000;
            ContractTypeImplement contract = new MonthlySalaryEmployee(salary);
            
            Assert.Equal<decimal>(expected:anualSalary,actual: contract.AnualSalary());
        }
        [Fact]
        public void AnualSalary_When_MonthlySalaryEmployee_Without_Value()
        {
            decimal anualSalary = 0;
            decimal salary = 0;
            ContractTypeImplement contract = new MonthlySalaryEmployee(salary);

            Assert.Equal<decimal>(expected: anualSalary, actual: contract.AnualSalary());
        }

    }
}
