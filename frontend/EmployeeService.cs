using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace frontend
{
    internal class EmployeeService
    {
        HttpClientHandler clientHandler = null;
        static HttpClient client = null;

        public EmployeeService()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            client = new HttpClient(clientHandler);
        }

        public void createConnection()
            {
            client.BaseAddress = new Uri("http://localhost:8080");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            }

        public List<Employee> getEmployees()
        {
            List<Employee> employees = null;
            HttpResponseMessage response = client.GetAsync("api/employee").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                employees = JsonSerializer.Deserialize<List<Employee>>(resultString);
                return employees;
            }
            return null;
        }
        public List<Employee> getEmployeesByDepartmentId(int id) { 
            List<Employee> employees= null;
            HttpResponseMessage response = client.GetAsync("api/employee/by-department/" + id.ToString()).Result;
            if(response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                employees=JsonSerializer.Deserialize<List<Employee>>(resultString);
                return employees;
            }
            return null;
        }
    }
}
