using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorManager.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public Department DepartmentDetails { get; set; }
        public string PhotoLocation { get; set; }

        public static async Task<IEnumerable<Employee>> FetchAllEmployees()
        {
            Task delayTask = Task.Delay(3000);
            Employee emp1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Sameer",
                LastName = "Khan",
                Email = "sameer@abc.com",
                DateOfBirth = new DateTime(1985, 11, 25),
                DepartmentDetails = new Department { DepartmentId = 1, DepartmentName = "HR" },
                Gender = GenderEnum.Male,
                PhotoLocation = "images/sameer.jpg"
            };

            Employee emp2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Falak",
                LastName = "Naaz",
                Email = "falak@abc.com",
                DateOfBirth = new DateTime(1991, 08, 03),
                DepartmentDetails = new Department { DepartmentId = 1, DepartmentName = "HR" },
                Gender = GenderEnum.Female,
                PhotoLocation = "images/falak.jpg"
            };

            Employee emp3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Tanveer",
                LastName = "Ahmed",
                Email = "tanveer@abc.com",
                DateOfBirth = new DateTime(1989, 05, 14),
                DepartmentDetails = new Department { DepartmentId = 2, DepartmentName = "Engineering" },
                Gender = GenderEnum.Male,
                PhotoLocation = "images/tanveer.jpg"
            };

            Employee emp4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Aira",
                LastName = "Khatun",
                Email = "aira@abc.com",
                DateOfBirth = new DateTime(1993, 02, 19),
                DepartmentDetails = new Department { DepartmentId = 3, DepartmentName = "Finance" },
                Gender = GenderEnum.Female,
                PhotoLocation = "images/aira.jpg"
            };

            await delayTask;

            return new List<Employee> { emp1, emp2, emp3, emp4 };
        }
    }
}
