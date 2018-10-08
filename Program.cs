using System;
using System.Collections.Generic;

namespace CompanyInfo {
    class Program {
        static void Main (string[] args)
        {
            Company LoomAndHammer = new Company("Loom & Hammer", new DateTime());

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

            LoomAndHammer.HireEmployee(Daniel);
            LoomAndHammer.HireEmployee(Ricky);
            LoomAndHammer.HireEmployee(Streator);

            foreach (Employee employee in LoomAndHammer.EmployeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}