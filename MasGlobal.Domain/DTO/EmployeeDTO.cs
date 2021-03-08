using MasGlobal.Domain.Models;

namespace MasGlobal.Domain.DTO
{
    public abstract class EmployeeDTO : EmployeeModel
    {
        protected decimal _yearSalary;
        public decimal YearSalary
        {
            get { return _yearSalary; }
        }

        public EmployeeDTO(EmployeeModel model)
        {
            Id = model.Id;
            Name = model.Name;
            ContractTypeName = model.ContractTypeName;
            RoleId = model.RoleId;
            RoleName = model.RoleName;
            RoleDescription = model.RoleDescription;
            HourlySalary = model.HourlySalary;
            MonthlySalary = model.MonthlySalary;
        }

        public abstract void CalculateYearSalary();
    }
}
