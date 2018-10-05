using System;
using System.Collections.Generic;

namespace CompanyInfo {
    public class Company {

        // Variables
        public DateTime DateFounded { get; set; }
        public string CompanyName { get; set; }
        public List<Employee> EmployeeList = new List<Employee> ();

        // Methods
        public void ListEmployees () { }
    }
}