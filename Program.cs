using System;
using System.Collections.Generic;

namespace CompanyInfo {
    class Program {
        static void Main (string[] args)
        {
            Company LoomAndHammer = new Company()
            {
                CompanyName = "Loom & Hammer",
                DateFounded = new DateTime(),
                EmployeeList = new List<Employee>()
            };
            Employee Daniel = new Employee ()
            {
                FirstName = "Daniel",
                LastName = "Figueroa",
                Title = "Meme Maker",
                StartDate = new DateTime()
            };
            Employee Ricky = new Employee ()
            {
                FirstName = "Ricky",
                LastName = "Bruner",
                Title = "CSS Master",
                StartDate = new DateTime()
            };
            Employee Streator = new Employee ()
            {
                FirstName = "Streator",
                LastName = "Ward",
                Title = "Delivery",
                StartDate = new DateTime()
            };

            // Create an instance of a company. Name it whatever you like.
            // Create three employees
            // Assign the employees to the company
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}