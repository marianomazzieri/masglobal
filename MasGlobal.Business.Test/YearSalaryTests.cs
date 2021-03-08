using MasGlobal.Business.Services;
using MasGlobal.Domain.DTO;
using MasGlobal.Domain.Interfaces;
using MasGlobal.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.JustMock;

namespace MasGlobal.Business.Test
{
    [TestClass]
    public class YearSalaryTests
    {
        [TestMethod]
        public void Test_YearSalary_MonthlyContract()
        {
            //Arrange
            decimal monthlySalary = 10000m;
            var expected = new List<EmployeeModel> { new EmployeeModel { ContractTypeName = "MonthlySalaryEmployee", MonthlySalary = monthlySalary } };

            var repository = Mock.Create<IEmployeeRepository>();
            Mock.Arrange(() => repository.GetAll()).Returns(expected);

            //Act
            var service = new EmployeeService(repository);
            var result = service.GetEmployees(null).FirstOrDefault().YearSalary;

            //Assert
            Assert.AreEqual(monthlySalary * 12, result);
        }

        [TestMethod]
        public void Test_YearSalary_HourlyContract()
        {
            //Arrange
            decimal hourlySalary = 10000m;
            decimal numHoursPerMonth = 120m;
            var expected = new List<EmployeeModel> { new EmployeeModel { ContractTypeName = "HourlySalaryEmployee", HourlySalary = hourlySalary } };

            var repository = Mock.Create<IEmployeeRepository>();
            Mock.Arrange(() => repository.GetAll()).Returns(expected);

            //Act
            var service = new EmployeeService(repository);
            var result = service.GetEmployees(null).FirstOrDefault().YearSalary;

            //Assert
            Assert.AreEqual(hourlySalary * numHoursPerMonth * 12, result);
        }
    }
}
