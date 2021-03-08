using MasGlobal.Domain.Models;
using System.Collections.Generic;

namespace MasGlobal.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        EmployeeModel GetById(int id);
        List<EmployeeModel> GetAll();
    }
}
