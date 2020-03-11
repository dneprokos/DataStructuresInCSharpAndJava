using System;
using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._6_Tree.OrganizationTree
{
    public class OrganizationHierarchy : IOrganization
    {
        public Employee CEO { get; }

        public OrganizationHierarchy(string seoFullName)
        {
            CEO = new Employee(JobTitle.CEO, seoFullName, null);
        }

        #region Public methods

        public Employee AddEmployee(string fullName, JobTitle position, Employee chief) 
        {
            Employee newEmployee = null;

            switch (position) 
            {
                case JobTitle.DIRECTOR:
                    newEmployee = AddEmployee(position, CEO, fullName);
                    break;
                case JobTitle.MANAGER:
                    newEmployee = AddEmployee(position, chief, fullName);
                    break;
                case JobTitle.EMPLOYEE:
                    newEmployee = AddEmployee(position, chief, fullName);
                    break;
                case JobTitle.CEO:
                    Console.WriteLine("CEO cannot be added as Employee. It has been created" +
                        "with an organization");
                    break;
            }
            
            return newEmployee;
        }

        public List<Employee> FindEmployee(string fullName)
        {
            List<Employee> employees = new List<Employee>();

            foreach (var employee in CEO.directSubordinates)
            {
                if (employee.fullName.ToLowerInvariant().Equals(fullName.ToLowerInvariant()))
                    employees.Add(employee);

                List<Employee> res = FindEmployee(fullName, employee);
                if (res != null)
                    employees.AddRange(res);
            }

            if (employees.Count == 0) 
            {
                Console.WriteLine("No employee with such name");
                employees = null;
            }              
            else 
                employees
                    .ForEach(e => 
                    Console.WriteLine($"Employee {fullName} with job title {e.position} was found"));

            return employees;
        }

        public Employee RemoveEmployee(Employee employee)
        {
            if (employee.directSubordinates != null) 
            {
                Console.WriteLine("Employee cannot be removed, because it has subordinates");
                return null;
            }

            employee.chief.directSubordinates.Remove(employee);

            Console.WriteLine($"Employee with name {employee.fullName} " +
                $"and title {employee.position} was removed");
            return employee;
        }

        public void PrintChiefsHierarchy(Employee employee)
        {
            if (employee == null) 
            {
                Console.WriteLine("Employee should not be null");
                return;
            }

            Console.Write($"{employee.fullName}");

            if (employee.chief != null)
                PrintName(employee.chief);
            else 
            {
                Console.Write(" does not have chiefs");
            }
        }

        

        #endregion

        #region Private methods

        private Employee AddEmployee(JobTitle position, Employee chief, string fullName)
        {
            Employee newEmployee = null;
            JobTitle expectedChiefJob = GetExpectedChiefPosition(position);

            if (chief.position == expectedChiefJob) 
            {
                newEmployee = new Employee(position, fullName, chief);
                chief.AddSubordinate(newEmployee);
            }          
            else
                Console.WriteLine($"Chief employee Title should be {expectedChiefJob}, " +
                    $"but you've specified employee with {chief.position} title.");


            if (!newEmployee.Equals(null))
                Console.WriteLine($"New employee {newEmployee.fullName} " +
                $"has joined the complany on position {newEmployee.position}");
            
            return newEmployee;
        }

        private JobTitle GetExpectedChiefPosition(JobTitle position) 
        {
            var employeeChief = new Dictionary<JobTitle, JobTitle>()
            {
                { JobTitle.EMPLOYEE, JobTitle.MANAGER },
                { JobTitle.MANAGER, JobTitle.DIRECTOR },
                { JobTitle.DIRECTOR, JobTitle.CEO }
            };

            return employeeChief[position];
        }

        private List<Employee> FindEmployee(string fullName, Employee node)
        {
            List<Employee> employees = new List<Employee>();

            if (node.directSubordinates != null)
            {
                foreach (Employee sub in node.directSubordinates)
                {
                    if (sub.fullName.ToLowerInvariant().Equals(fullName.ToLowerInvariant()))
                        employees.Add(sub);
                    if (sub.directSubordinates != null) 
                    {
                        List<Employee> res = FindEmployee(fullName, sub);
                        if (res != null)
                            employees.AddRange(res);
                    }                       
                }
                return employees;
            }
            else
                return null;
        }

        private void PrintName(Employee employee)
        {
            Console.Write($" --> {employee.fullName}");

            if (employee.chief != null)
                PrintName(employee.chief);
            else
            {
                Console.Write("\n");
                return;
            }
        }

        #endregion
    }
}
