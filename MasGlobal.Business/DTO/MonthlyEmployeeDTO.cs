using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Models;

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
