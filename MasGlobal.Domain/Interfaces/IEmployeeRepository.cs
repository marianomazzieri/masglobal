using MasGlobal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        EmployeeModel GetById(int id);
        List<EmployeeModel> GetAll();
    }
}
