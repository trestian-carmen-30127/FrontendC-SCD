using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace frontend
{
    internal class DepartmentService
       
    {
        HttpClientHandler handler = null;
        static HttpClient client = null;
        public DepartmentService()
        {
            handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            client = new HttpClient(handler);
        }

        public void createDepartmentConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public List<Department> getDepartmentList()
        {
            List<Department> departments = null;
            HttpResponseMessage response = client.GetAsync("api/department").Result;
            if(response.IsSuccessStatusCode)
            {
                string resultString= response.Content.ReadAsStringAsync().Result;
                departments= JsonSerializer.Deserialize<List<Department>>(resultString);
                return departments;
            }
            return null;

        }

        public bool addDepartment(Department department)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/department", department).Result;
            return response.IsSuccessStatusCode;
        }

        public bool updateDepartment(Department department)
        {
            HttpResponseMessage response = client.PutAsJsonAsync("api/department", department).Result;
            return response.IsSuccessStatusCode;
        }

        public bool deleteDepartment(Department department)
        {
            HttpResponseMessage response = client.PutAsJsonAsync("api/department", department).Result;
            return response.IsSuccessStatusCode;
        }
    }
}
