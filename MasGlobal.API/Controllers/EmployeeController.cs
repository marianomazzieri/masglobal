using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace MasGlobal.API.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET api/employee
        public List<EmployeeDTO> Get()
        {
            return _employeeService.GetEmployees(null);
        }

        // GET api/employee/5
        public List<EmployeeDTO> Get(int id)
        {
            return _employeeService.GetEmployees(id);
        }
    }
}
