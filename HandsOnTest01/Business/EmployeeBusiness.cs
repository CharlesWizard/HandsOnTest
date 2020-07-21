using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EmployeeBusiness
    {
        public struct ContractTypes
        {
            public const string HOURLY = "HourlySalaryEmployee";
            public const string MONTH  = "MonthlySalaryEmployee";
        }
        public readonly string url;
        public EmployeeBusiness(string uri)
        {
            this.url = uri;
        }
        public async Task<List<EmployeeDTO>> GetEmployees(int id=0)
        {
            EmployeeService employeeService = new EmployeeService(this.url);
            List<Employee> employees = await employeeService.GetEmployees(id);
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            try
            {
                employeeDTOs = (from emp in employees.ToList()
                                select emp)
                      .Select(emp => new EmployeeDTO
                      {
                          id               = emp.id,
                          name             = emp.name,
                          contractTypeName = emp.contractTypeName,
                          roleName         = emp.roleName,
                          hourlySalary     = emp.hourlySalary,
                          monthlySalary    = emp.monthlySalary,
                          AnualSalary      = this.GetSalaryByContractType(emp.contractTypeName, emp.hourlySalary,emp.monthlySalary)
                      })
                      .ToList();
            }
            catch (Exception)
            {
                //LOG
            }
            
            return employeeDTOs;
        }
        private decimal GetSalaryByContractType(string contractType,decimal hourlySalary,decimal monthlySalary)
        {
            ContractType contract = null;
            switch (contractType)
            {
                case ContractTypes.HOURLY:
                    contract = new HourlySalaryEmployee(hourlySalary);
                   
                    break;
                case ContractTypes.MONTH:
                    contract = new MonthlySalaryEmployee(monthlySalary);
                    break;
                default:
                    return 0;
            }
            return contract.AnualSalary();
        }
    }
}
