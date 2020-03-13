using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Security.DTO
{
    public class Employees
    {
        public int IDNumber { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string company { get; set; }
        public string emailaddress { get; set; }
        public string cellphonenumber { get; set; }
        public int department { get; set; }
        public int employeetype { get; set; }
        public string description { get; set; }
    }

    public class EmployeesDTO
    {
        public int IDNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNumber { get; set; }
        public int Department { get; set; }
        public int EmployeeType { get; set; }
        public string Description { get; set; }
    }
}