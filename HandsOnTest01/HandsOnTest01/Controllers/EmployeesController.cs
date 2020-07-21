using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Data;
using HandsOnTest01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models;

namespace HandsOnTest01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IOptions<ExternalConection> _config;
        public string urlEmployeesRepository { get { return null; } }

        public EmployeesController(ILogger<EmployeesController> logger, IOptions<ExternalConection> options)
        {
            _logger = logger;
            this._config = options;
        }

        
        [HttpGet]
        public IEnumerable<EmployeeDTO> Get(int id)
        {

            EmployeeBusiness employeeBusiness = new EmployeeBusiness(this._config.Value.EmployeesRepository);
            return employeeBusiness.GetEmployees(id).Result;

        }
    }
}
