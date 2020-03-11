using System;
using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._6_Tree.OrganizationTree
{
    public class Employee
    {
        public Employee(JobTitle position, string fullName, Employee chief)
        {
            this.position = position;
            this.fullName = fullName;
            this.chief = chief;
        }

        public List<Employee> directSubordinates { get; set; }
        public JobTitle position { get; set; }
        public string fullName { get; set; }
        public Employee chief { get; set; }

        public void AddSubordinate(Employee node)
        {
            if (directSubordinates == null)
                directSubordinates = new List<Employee>();
            directSubordinates.Add(node);
        }

        public void PrintDetails()
        {
            Console.WriteLine("########Employee Details########");
            Console.WriteLine($"Full Name: {fullName}\nTitle: {position}");
        }

        public void PrintSubordinateDetails()
        {
            Console.WriteLine($"#####{fullName} has following subordinates ############");

            directSubordinates.ForEach(s =>
            {
                Console.WriteLine("##########Employee#########");
                Console.WriteLine($"Full Name: {s.fullName}");
                Console.WriteLine($"Job Title: {s.position}");

                if (s.directSubordinates != null)
                    s.PrintSubordinateDetails();
            });
        }
    }
}
