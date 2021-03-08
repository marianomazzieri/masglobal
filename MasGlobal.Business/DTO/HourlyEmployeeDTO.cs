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
    public class HourlyEmployeeDTO : EmployeeDTO
    {  
        public HourlyEmployeeDTO(EmployeeModel model) : base(model)
        {

        }

        public override void CalculateYearSalary()
        {
            _yearSalary = 120m * HourlySalary * 12m;
        }
    }
}
