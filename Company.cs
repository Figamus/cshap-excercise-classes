using System;
using System.Collections.Generic;

namespace CompanyInfo {
    public class Company {
        // Variables
        public string CompanyName { get; set; }
        public DateTime DateFounded { get; set; }
        public List<Employee> EmployeeList = new List<Employee> ();
        // Methods
        public void HireEmployee (Employee employee)
        {
            EmployeeList.Add(employee);
        }
    }
}