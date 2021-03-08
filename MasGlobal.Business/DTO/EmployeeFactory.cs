using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Business.DTO
{
    internal class EmployeeFactory
    {
        internal EmployeeFactory()
        {

        }

        internal EmployeeDTO CreateEmployeeDTO(EmployeeModel model)
        {
            EmployeeDTO employee = null;

            switch (model.ContractTypeName.ToLower())
            {
                case "hourlysalaryemployee":
                    employee = new HourlyEmployeeDTO(model);
                    break;
                case "monthlysalaryemployee":
                    employee = new MonthlyEmployeeDTO(model);
                    break;
            }

            return employee;
        }
    }
}
