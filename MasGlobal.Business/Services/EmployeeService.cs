using MasGlobal.Business.DTO;
using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Interfaces;
using MasGlobal.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MasGlobal.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Returns a list of employees
        /// </summary>
        /// <param name="id">optional,  it specifies an Id to filter by</param>
        /// <returns>Returns a list of EmployeeDTO objects</returns>
        public List<EmployeeDTO> GetEmployees(int? id) 
        {
            var result = new List<EmployeeDTO>();
            var factory = new EmployeeFactory();

            var employees = _repository.GetAll();

            if(id.HasValue)            
            {
                employees = employees.Where(e => e.Id == id.Value).ToList();
            }

           foreach(EmployeeModel e in employees)
            {
                var dto = factory.CreateEmployeeDTO(e);
                dto.CalculateYearSalary();
                
                result.Add(dto);
            }

            return result;
        }
    }
}
