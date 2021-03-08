using MasGlobal.Domain.DTO;
using System.Collections.Generic;

namespace MasGlobal.Domain.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetEmployees(int? id);
    }
}
