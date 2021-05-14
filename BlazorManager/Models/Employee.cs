using System;

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
    }
}
