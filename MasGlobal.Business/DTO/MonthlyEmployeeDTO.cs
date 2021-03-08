using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Interfaces;
using MasGlobal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Business.DTO
{
    public class MonthlyEmployeeDTO : EmployeeDTO
    {
        public MonthlyEmployeeDTO(EmployeeModel model) : base(model)
        {

        }

        public override void CalculateYearSalary()
        {
            _yearSalary = MonthlySalary * 12;
        }
    }
}
