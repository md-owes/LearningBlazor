using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorManager.Models;

namespace BlazorServer.Pages
{
    public partial class EmployeeList
    {
        public IEnumerable<Employee> lstEmployees { get; set; }

        public EmployeeList()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            lstEmployees = await Employee.FetchAllEmployees();
        }
    }
}
