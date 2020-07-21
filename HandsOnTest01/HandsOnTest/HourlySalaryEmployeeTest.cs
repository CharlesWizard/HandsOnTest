
using Business;
using System;
using Xunit;

namespace HandsOnTest
{
    public class HourlySalaryEmployeeTest
    {
        [Fact]
        public void AnualSalary_When_HourlySalaryEmployee_Has_Value()
        {
            decimal anualSalary = 86400000;
            decimal salary = 60000;
            ContractTypeImplement contract = new HourlySalaryEmployee(salary);
            
            Assert.Equal<decimal>(expected:anualSalary,actual: contract.AnualSalary());
        }
        [Fact]
        public void AnualSalary_When_HourlySalaryEmployee_Without_Value()
        {
            decimal anualSalary = 0;
            decimal salary = 0;
            ContractTypeImplement contract = new HourlySalaryEmployee(salary);

            Assert.Equal<decimal>(expected: anualSalary, actual: contract.AnualSalary());
        }

    }
}
