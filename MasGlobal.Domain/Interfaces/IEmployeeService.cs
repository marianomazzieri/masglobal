using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Domain.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetEmployees(int? id);
    }
}
