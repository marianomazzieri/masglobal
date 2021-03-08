using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Models;

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
