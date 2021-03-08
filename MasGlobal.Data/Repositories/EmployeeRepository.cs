using MasGlobal.Domain.Interfaces;
using MasGlobal.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private string _employeeApiBaseUrl;
        private HttpClient _httpClient;

        public EmployeeRepository()
        {
            _employeeApiBaseUrl = ConfigurationManager.AppSettings["EmployeeApiUrl"];
            _httpClient = new HttpClient();
        }

        public List<EmployeeModel> GetAll()
        {
            string url = _employeeApiBaseUrl;

            using (var response = _httpClient.GetAsync(url).Result)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var employees = JsonConvert.DeserializeObject<List<EmployeeModel>>(data);

                if (employees != null)
                    return employees;
            }

            return new List<EmployeeModel>();
        }

        public EmployeeModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
