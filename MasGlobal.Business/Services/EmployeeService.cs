using MasGlobal.Business.DTO;
using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Interfaces;
using MasGlobal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

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
