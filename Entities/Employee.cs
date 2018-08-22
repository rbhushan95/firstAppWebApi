using System;

namespace Entities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public Address EmployeeAddress { get; set; }
    }
}
