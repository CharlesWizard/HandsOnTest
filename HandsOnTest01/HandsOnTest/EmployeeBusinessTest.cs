using Business;
using Models;
using System;
using System.Linq;
using Xunit;

namespace HandsOnTest
{
    public class EmployeeBusinessTest
    {
        public string urlApiEmployees { get { return @"http://masglobaltestapi.azurewebsites.net/api/Employees"; } }
        #region Success
        [Fact]
        public void GetEmployees_When_All_Employees()
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness(urlApiEmployees);
            var result = employeeBusiness.GetEmployees().Result;
            Assert.True(result.Count > 1);
        }
        [Fact]
        public void GetEmployees_When_One_Employee()
        {
            int id = 1;
            EmployeeBusiness employeeBusiness = new EmployeeBusiness(urlApiEmployees);
            var result = employeeBusiness.GetEmployees(id).Result;
            EmployeeDTO employee = result.FirstOrDefault();
            Assert.True(employee.id==id);
        }
        #endregion
        #region Error
        [Fact]
        public void GetEmployees_When_Api_Not_Found()
        {
            string urlApiEmployeesFailed = string.Empty;
            EmployeeBusiness employeeBusiness = new EmployeeBusiness(urlApiEmployeesFailed);
            var result = employeeBusiness.GetEmployees().Result;
            Assert.True(result.Count == default(int));
        }
        #endregion

    }
}
