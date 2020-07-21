using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tools;

namespace Data
{
    public class EmployeeService
    {
        private readonly string url;
        public EmployeeService(string url)
        {
            this.url = url;
        }
        public async Task<List<Employee>> GetEmployees(int id)
        {
            var employees = new List<Employee>();
            
            try
            {
                string responseString = await HttpClientHelper.GetString(this.url);
                employees = JsonConvert.DeserializeObject<List<Employee>>(responseString);
            }
            catch (Exception ex)
            {
                //TODO: Log
            }
            
            if (id==default(int)) { return employees; }
            return employees.FindAll(employee=>id.Equals(employee.id));
        }
    }
}
